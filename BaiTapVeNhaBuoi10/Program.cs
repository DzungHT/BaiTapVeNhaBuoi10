using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaiTapVeNhaBuoi10.View;

namespace BaiTapVeNhaBuoi10
{
    class Program
    {
        static void Main(string[] args)
        {
            MainView mainView = new MainView();
            while (true)
            {
                mainView.Show();
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
