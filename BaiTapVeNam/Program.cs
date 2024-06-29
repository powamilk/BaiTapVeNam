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
                    int nam = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Tên gọi của năm {nam} là: {service.TenGoiCuaNam(nam)}");
                    break;
                case 2:
                    Console.Write("Nhập tháng: ");
                    int thang = int.Parse(Console.ReadLine());
                    Console.Write("Nhập năm: ");
                    nam = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Số ngày trong tháng {thang}/{nam} là: {service.TimSoNgayCuaThang(thang, nam)}");
                    break;
                case 3:
                    Console.Write("Nhập ngày: ");
                    int ngay = int.Parse(Console.ReadLine());
                    Console.Write("Nhập tháng: ");
                    thang = int.Parse(Console.ReadLine());
                    Console.Write("Nhập năm: ");
                    nam = int.Parse(Console.ReadLine());
                    Console.WriteLine(service.KiemTraNgayHopLe(ngay, thang, nam));
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