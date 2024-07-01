using BaiTapVeNam;
using System;

class Program
{
    static void Main(string[] args)
    {
        Service service = new Service();
        while (true)
        {
            Console.WriteLine("Chọn chức năng:");
            Console.WriteLine("1. Tên gọi của năm");
            Console.WriteLine("2. Tìm số ngày của tháng");
            Console.WriteLine("3. Kiểm tra ngày hợp lệ");
            Console.WriteLine("4. Thoát");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Nhập năm: ");
                    if (int.TryParse(Console.ReadLine(), out int nam))
                    {
                        string tenGoi = service.TenGoiCuaNam(nam);
                        Console.WriteLine($"Tên gọi của năm {nam} là: {tenGoi}");
                    }
                    else
                    {
                        Console.WriteLine("Dữ liệu nhập không hợp lệ. Vui lòng nhập số nguyên.");
                    }
                    break;
                case 2:
                    Console.Write("Nhập tháng: ");
                    if (int.TryParse(Console.ReadLine(), out int thang))
                    {
                        Console.Write("Nhập năm: ");
                        if (int.TryParse(Console.ReadLine(), out int namThang))
                        {
                            int soNgay = service.TimSoNgayCuaThang(thang, namThang);
                            if (soNgay == -1)
                                Console.WriteLine("Tháng không hợp lệ.");
                            else
                                Console.WriteLine($"Số ngày của tháng {thang} năm {namThang} là: {soNgay}");
                        }
                        else
                        {
                            Console.WriteLine("Dữ liệu nhập không hợp lệ. Vui lòng nhập số nguyên.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Dữ liệu nhập không hợp lệ. Vui lòng nhập số nguyên.");
                    }
                    break;
                case 3:
                    Console.Write("Nhập ngày: ");
                    if (int.TryParse(Console.ReadLine(), out int ngay))
                    {
                        Console.Write("Nhập tháng: ");
                        if (int.TryParse(Console.ReadLine(), out int thangNgay))
                        {
                            Console.Write("Nhập năm: ");
                            if (int.TryParse(Console.ReadLine(), out int namNgay))
                            {
                                string ketQua = service.KiemTraNgayHopLe(ngay, thangNgay, namNgay);
                                Console.WriteLine(ketQua);
                            }
                            else
                            {
                                Console.WriteLine("Dữ liệu nhập không hợp lệ. Vui lòng nhập số nguyên.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Dữ liệu nhập không hợp lệ. Vui lòng nhập số nguyên.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Dữ liệu nhập không hợp lệ. Vui lòng nhập số nguyên.");
                    }
                    break;
                case 4:
                    return;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại.");
                    break;
            }
        }
    }
}