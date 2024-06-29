using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapVeNam
{
    class Service
    {
        private string[] CAN = { "Canh", "Tân", "Nhâm", "Quý", "Giáp", "Ất", "Bính", "Đinh", "Mậu", "Kỷ" };
        private string[] CHI = { "Thân", "Dậu", "Tuất", "Hợi", "Tý", "Sửu", "Dần", "Mão", "Thìn", "Tỵ", "Ngọ", "Mùi" };

        public string TenGoiCuaNam(int nam)
        {
            string can = CAN[nam % 10];
            string chi = CHI[nam % 12];
            return $"{can} {chi}";
        }

        public int TimSoNgayCuaThang(int thang, int nam)
        {
            if (thang < 1 || thang > 12) return -1;

            if (thang == 2)
            {
                if (NamNhuan(nam))
                    return 29;
                else
                    return 28;
            }

            if (thang == 4 || thang == 6 || thang == 9 || thang == 11)
                return 30;

            return 31;
        }

        public bool NamNhuan(int nam)
        {
            return (nam % 400 == 0) || (nam % 4 == 0 && nam % 100 != 0);
        }

        public string KiemTraNgayHopLe(int ngay, int thang, int nam)
        {
            if (nam <= 0 || thang <= 0 || ngay <= 0) return $"{ngay}/{thang}/{nam} không hợp lệ";

            if (thang > 12) return $"{ngay}/{thang}/{nam} không hợp lệ";

            int soNgay = TimSoNgayCuaThang(thang, nam);
            if (ngay > soNgay) return $"{ngay}/{thang}/{nam} không hợp lệ";

            return $"{ngay}/{thang}/{nam} hợp lệ";
        }
    }
}
