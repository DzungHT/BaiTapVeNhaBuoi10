using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapVeNhaBuoi10.Logic
{
    class BaiTap1
    {
        public int X { get; set; }
        public int Y { get; set; }

        public int Tong()
        {
            return X + Y;
        }

        public int Hieu()
        {
            return X - Y;
        }
        public int Tich()
        {
            return X * Y;
        }
        public bool Thuong(out double result)
        {
            result = 0;
            if(Y != 0)
            {
                result = X / Y;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
