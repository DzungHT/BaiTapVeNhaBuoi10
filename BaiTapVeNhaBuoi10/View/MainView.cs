using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapVeNhaBuoi10.View
{
    class MainView
    {
        /// <summary>
        /// Hàm hiển thị menu
        /// </summary>
        /// <returns>Trả về menu được chọn</returns>
        public int Menu()
        {
            Console.WriteLine("1. Bai tap 1");
            // Viết thêm menu ở đây

            Console.WriteLine();
            Console.WriteLine("0. Thoat");
            Console.WriteLine("==============================================");
            Console.Write("Chon: ");


            int option;
            if(!int.TryParse(Console.ReadLine(), out option))
            {
                option = -1;
            }

            return option;

        }

        public void Show()
        {
            Console.WriteLine("==============================================");
            Console.WriteLine("|                                            |");
            Console.WriteLine("|          Bai tap ve nha buoi 10            |");
            Console.WriteLine("|                                            |");
            Console.WriteLine("==============================================");

            int option = Menu();

            switch (option)
            {
                case 1:
                    Menu1View view = new Menu1View();
                    view.Show();
                    break;

                case 0:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Menu không hợp lệ");
                    break;
            }


        }
    }
}
