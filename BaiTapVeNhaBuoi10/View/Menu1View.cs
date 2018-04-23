using BaiTapVeNhaBuoi10.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapVeNhaBuoi10.View
{
    class Menu1View
    {
        private int NhapSoNguyen(string varName)
        {
            while (true)
            {
                Console.WriteLine(" Nhap {0} = ", varName);
                int x;
                if (int.TryParse(Console.ReadLine(), out x))
                {
                    return x;
                }
                else
                {
                    Console.WriteLine("Gia tri khong hop le!");
                }
            }
        }

        public void Show()
        {
            Console.Clear();
            ShowTieuDe();


            int x, y;
            BaiTap1 baiTap1 = new BaiTap1();

            baiTap1.X = NhapSoNguyen("x");
            baiTap1.Y = NhapSoNguyen("y");

            ShowKetQua(baiTap1);

        }

        private void ShowKetQua(BaiTap1 baiTap1)
        {
            Console.Clear();
            ShowTieuDe();
            Console.WriteLine();
            Console.WriteLine("2 so vua nhap la: x = {0}, y = {1}", baiTap1.X, baiTap1.Y);
            Console.WriteLine("Tong: {0}\nHieu: {1}\nTich:{2}", baiTap1.Tong(), baiTap1.Hieu(), baiTap1.Tich());

            double thuong;
            if (baiTap1.Thuong(out thuong))
            {
                Console.WriteLine("Thuong: {0}", thuong);
            }
            else
            {
                Console.WriteLine("Thuong: (Loi khong chia duoc cho 0)");
            }

            Console.WriteLine("================================");
            Console.WriteLine("Bam phim bat ky de tiep tuc!");
        }

        private void ShowTieuDe()
        {
            Console.WriteLine("==============================================");
            Console.WriteLine("|                                            |");
            Console.WriteLine("|                Bai Tap 1                   |");
            Console.WriteLine("|                                            |");
            Console.WriteLine("==============================================");
        }
    }
}
