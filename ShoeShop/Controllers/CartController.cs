using Microsoft.AspNetCore.Mvc.Infrastructure;
using ProjectShoeShop.DAL;
using ProjectShoeShop.Models;
using ProjectShoeShop.ViewModel;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Security.Permissions;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace ProjectShoeShop.Controllers
{
    public class CartController : Controller
    {
        ShoeShopDbContext db = new ShoeShopDbContext();
        // GET: Cart
        public ActionResult CartLayout()
        {
            return View();
        }
        public List<CartVM> GetCart()
        {
            List<CartVM> lstCart = Session["Cart"] as List<CartVM>;
            if(lstCart == null)
            {
                lstCart= new List<CartVM>();
                Session["Cart"] = lstCart;
            }
            return lstCart;
        }
        public ActionResult AddCart(string ProductId, string strURL)
        {
            List<CartVM> lstCart = GetCart();
            CartVM pro = lstCart.Find(x => x.Id == ProductId);

            User us = (User)Session["User"];

            if (us == null)
            {
                return RedirectToAction("Login", "Account");
            }

            int cntExistProduct = db.Products
                .Where(p => p.Id == ProductId)
                .Select(p => p.Stock)
                .FirstOrDefault();

            if (cntExistProduct <= 0)
            {
                TempData["OutOfStockMessage"] = "Out of stock, please choose another item";
                return RedirectToAction("ShowProduct", "Product");
            }

            if (pro == null)
            {
                pro = new CartVM(ProductId);
                lstCart.Add(pro);
            }
            else
            {
                pro.Quantity += 1;
            }
            return Redirect(strURL);
        }
        [HttpPost]
        public ActionResult AddCartDetail(string ProductId, string strURL, FormCollection f)
        {
            string returnUrl = Request.UrlReferrer?.ToString() ?? Url.Action("showProduct", "Product");

            List<CartVM> lstCart = GetCart();
            CartVM pro = lstCart.Find(x => x.Id == ProductId);

            User us = (User)Session["User"];

            if (us == null)
            {
                return RedirectToAction("Login", "Account");
            }

            if (int.Parse(f["Quantity"]) <= 0)
            {
                TempData["OutOfStockMessage"] = "Please select quantity";
                return Redirect(returnUrl);
            }

            if (pro == null)
            {
                pro = new CartVM(ProductId);
                pro.Quantity = int.Parse(f["Quantity"].ToString());
                lstCart.Add(pro);
            }
            else
            {
                pro.Quantity += 1;
            }
            var name = db.Products.Where(x => x.Id == ProductId).Select(x => x.Name).FirstOrDefault();
            var str = strURL +"&ProductName="+ name;
            return Redirect(str);
        }
        public int TotalProduct()
        {
            int total = 0;
            List<CartVM> lstCart = Session["Cart"] as List<CartVM>;
            if(lstCart != null)
            {
                total = lstCart.Sum(x => x.Quantity);
            }
            return total;
        }
        public double TotalMoney()
        {
            double total = 0;
            List<CartVM> lstCart = Session["Cart"] as List<CartVM>;
            if (lstCart != null)
            {
                total = lstCart.Sum(x => x.Total);
            }
            return total;
        }
        public ActionResult ShowCart()
        {
            if (Session["Cart"] == null)
            {
                return RedirectToAction("ShowProduct", "Product");
            }
            else
            {
                List<CartVM> lstCart = Session["Cart"] as List<CartVM>;
                ViewBag.TotalProduct = TotalProduct();
                ViewBag.TotalMoney = TotalMoney();
                return View(lstCart);
            }
        }
        public ActionResult CartPartial()
        {
            ViewBag.TotalProduct = TotalProduct();
            ViewBag.TotalMoney = TotalMoney();
            return View();
        }
        public ActionResult RemoveCart(string ProductId)
        {
            List<CartVM> lstCart = GetCart();
            CartVM pro = lstCart.Where(x => x.Id == ProductId).FirstOrDefault();
            if(pro != null)
            {
                lstCart.RemoveAll(x => x.Id == ProductId);
                return RedirectToAction("ShowCart", "Cart");
            }
            if(lstCart.Count == 0)
            {
                return RedirectToAction("ShowProduct", "Product");
            }
            return RedirectToAction("ShowCart", "Cart");
        }
        public ActionResult UpdateCart(string ProductId, FormCollection f)
        {
            List<CartVM> lstCart = GetCart();
            CartVM pro = lstCart.Where(x => x.Id == ProductId).FirstOrDefault();

            int cntExistProduct = db.Products
                .Where(p => p.Id == ProductId)
                .Select(p => p.Stock)
                .FirstOrDefault();

            if(cntExistProduct < int.Parse(f["Quantity"]))
            {
                TempData["OutOfStockMessage"] = "Over stock";
                return RedirectToAction("ShowCart", "Cart");
            }

            if (pro != null)
            {
                pro.Quantity = int.Parse(f["Quantity"].ToString());
            }
            return RedirectToAction("ShowCart", "Cart");
        }
        public ActionResult BuyNow(string ProductId)
        {
            string returnUrl = Request.UrlReferrer?.ToString() ?? Url.Action("showProduct", "Product");

            List<CartVM> lstCart = GetCart();
            CartVM pro = lstCart.Find(x => x.Id == ProductId);
            int cntExistProduct = db.Products
                .Where(p => p.Id == ProductId)
                .Select(p => p.Stock)
                .FirstOrDefault();

            if(cntExistProduct <= 0)
            {
                TempData["OutOfStockMessage"] = "Out of stock, please choose another item";
                return Redirect(returnUrl);
            }

            if (pro == null)
            {
                pro = new CartVM(ProductId);
                lstCart.Add(pro);
            }
            else
            {
                pro.Quantity += 1;
            }
            return RedirectToAction("CheckOut");
        }
        public ActionResult CheckOutLayout()
        {
            return View();
        }
        public ActionResult CheckOutSucess(string id)
        {
            ViewBag.TotalMoney = TotalMoney();
            ViewBag.OrderId = id;
            return View();
        }
        [HttpGet]
        public ActionResult CheckOut(string strURL)
        {
            List<CartVM> lstCart = GetCart();
            CheckoutVM checkout = new CheckoutVM();
            if (lstCart.Count > 0)
            {
                User us = (User)Session["User"];

                if(us == null)
                {
                    return RedirectToAction("Login", "Account");
                }
                else
                {
                    checkout.Fullname = us.FullName;
                    checkout.Address = us.Address;
                    checkout.Phone = us.Phone;
                    checkout.Email = us.Email;
                    checkout.PaymentMethod = null;

                    ViewBag.TotalProduct = TotalProduct();
                    ViewBag.TotalMoney = TotalMoney();
                    return View(checkout);
                }
            }
            else
            {
                return Redirect(strURL);
            }
        }
        [HttpPost]
        public ActionResult CheckOut(CheckoutVM obj)
        {
            User user = (User)Session["User"];
            Order order = new Order()
            {
                Id = Guid.NewGuid().ToString().Substring(0, 7),
                UserID = user.Id,
                ShippingAddress = obj.Address,
                PaymentMethod = obj.PaymentMethod,
                OrderStatus = "Prepare",
                DeliveryStatus = "Prepare",
                OrderDate = DateTime.Now,
            };
            db.Orders.Add(order);
            db.SaveChanges();

            List<CartVM> lstCart = GetCart();
            foreach (var item in lstCart)
            {
                OrderDetail orderDetail = new OrderDetail()
                {
                    Id = Guid.NewGuid().ToString().Substring(0, 7),
                    OrderId = order.Id,
                    ProductId = item.Id,
                    Quantity = item.Quantity,
                    Price = item.Price,
                };
                Product product = db.Products
                    .Where(x => x.Id == orderDetail.ProductId)
                    .FirstOrDefault();

                product.Stock = product.Stock - orderDetail.Quantity;
                db.OrderDetails.Add(orderDetail);
                try
                {
                    db.SaveChanges();
                }
                catch (System.Data.Entity.Validation.DbEntityValidationException ex)
                {
                    foreach (var validationErrors in ex.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            System.Diagnostics.Debug.WriteLine($"Property: {validationError.PropertyName} Error: {validationError.ErrorMessage}");
                        }
                    }
                    throw;
                }
            }
            return RedirectToAction("CheckOutSucess", new {id=order.Id});
        }
    }
}