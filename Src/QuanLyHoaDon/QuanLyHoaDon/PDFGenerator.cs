using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Windows.Forms;
using Font = iTextSharp.text.Font;

namespace QuanLyHoaDon
{
    public class PDFGenerator
    {
        public void GenerateInvoicePDF(string filePath, string fileName, string maHoaDon, string khachHang, string diaChi, string ngayDat, string trangThai, string paymentMethod, string tinhTrangGiaoHang, DataGridView dgvOrderDetails, string tongTien)
        {
            // Tạo file PDF
            string fullPath = Path.Combine(filePath, $"{fileName}.pdf"); // Kết hợp đường dẫn và tên tệp
            Document document = new Document();
            PdfWriter.GetInstance(document, new FileStream(fullPath, FileMode.Create));

            document.Open();

            // Tạo font chữ "Arial" cho tiếng Việt
            BaseFont bf = BaseFont.CreateFont(@"C:\Windows\Fonts\arial.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED); // Đường dẫn tới font Arial
            Font fontTitle = new Font(bf, 18, Font.BOLD);
            Font fontNormal = new Font(bf, 12, Font.NORMAL);
            Font fontBold = new Font(bf, 12, Font.BOLD);

            // Thêm tiêu đề
            Paragraph title = new Paragraph("Thông Tin Hóa Đơn", fontTitle);
            title.Alignment = Element.ALIGN_CENTER;
            document.Add(title);

            // Thêm thông tin hóa đơn
            document.Add(new Paragraph("Mã hóa đơn: " + maHoaDon, fontBold));
            document.Add(new Paragraph("Khách hàng: " + khachHang, fontBold));
            document.Add(new Paragraph("Địa chỉ: " + diaChi, fontBold));
            document.Add(new Paragraph("Ngày đặt: " + ngayDat, fontBold));
            document.Add(new Paragraph("Trạng thái hóa đơn: " + trangThai, fontBold));
            document.Add(new Paragraph("Phương thức thanh toán: " + paymentMethod, fontBold));
            document.Add(new Paragraph("Tình trạng giao hàng: " + tinhTrangGiaoHang, fontBold));

            document.Add(new Paragraph("\n")); // Thêm khoảng cách

            // Tạo bảng cho chi tiết đơn hàng
            PdfPTable table = new PdfPTable(dgvOrderDetails.Columns.Count);
            table.WidthPercentage = 100;

            // Thêm tiêu đề cột
            foreach (DataGridViewColumn column in dgvOrderDetails.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, fontBold));
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
            }

            // Thêm dữ liệu từng dòng từ DataGridView vào PDF
            foreach (DataGridViewRow row in dgvOrderDetails.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    table.AddCell(new Phrase(cell.Value?.ToString(), fontNormal));
                }
            }

            document.Add(table);

            // Thêm tổng tiền
            Paragraph totalAmount = new Paragraph("Tổng tiền: " + tongTien, fontBold);
            totalAmount.Alignment = Element.ALIGN_RIGHT;
            totalAmount.SpacingBefore = 20;
            document.Add(totalAmount);

            // Đóng file PDF
            document.Close();
        }

    }
}
