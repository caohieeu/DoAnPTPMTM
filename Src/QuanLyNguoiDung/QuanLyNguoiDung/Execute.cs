using Core.DAL;
using Microsoft.VisualBasic.ApplicationServices;
using ProjectPTUDTM;
using QuanLyNguoiDung.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNguoiDung
{
    public class Execute
    {
        private readonly MyDao _myDao;
        public Execute(MyDao myDao)
        {
            _myDao = myDao;
        }
        public List<string> ValidateUser(Users user)
        {
            var validationResults = new List<ValidationResult>();
            var validationContext = new ValidationContext(user);

            bool isValid = Validator.TryValidateObject(user, validationContext, validationResults);

            List<string> errors = new List<string>();
            if(!isValid)
            {
                foreach(var validationResult in validationResults)
                {
                    errors.Add(validationResult.ErrorMessage);
                }
            }

            return errors;
        }
        private bool ShowError(Users user)
        {
            var errors = ValidateUser(user);

            if (errors.Count > 0)
            {
                MessageBox.Show(string.Join(Environment.NewLine, errors),
                    "Validate Errors", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        public bool Add(Users user)
        {
            if(ShowError(user))
            {
                var password = user.Password;
                user.Password = BCrypt.Net.BCrypt.HashPassword(password);

                return _myDao.Add(user);
            }
            
            return false;
        }
        public Users FindUserById(string userId)
        {
            return _myDao.GetUser(userId);
        }
        public bool UpdateUser(Users user)
        {
            return _myDao.Update(user);
        }
        public bool DeleteUser(string userId)
        {
            return _myDao.Delete(userId);
        }
        public List<Role> GetRoles()
        {
            return _myDao.GetRoles();
        }
    }
}
