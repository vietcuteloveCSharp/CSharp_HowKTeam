using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai8_Generic
{
    internal class Program
    {
        //public static void Swap(ref int a, ref int b)
        //{
        //    int temp = a;
        //    a = b;
        //    b = temp;
        //}
        public static void Swap<T>(ref T a, ref T b) // T là tên tạm thời , thay thế kdl khi bạn chuyền vào . Có thể đặt cái gì cũng đc K Y R,....
        {
            T temp = a;
            a = b;
            b = temp;
        }
        static void Main(string[] args)
        {
            #region Generic cho phương thức
            /*
             * Generic cho phép bạn định nghĩa 1 hàm , 1 lớp mà không cần chỉ ra đối số ,kdl . Tuỳ vào kdl mà người dùng chuyền vào thì nó sẽ hoạt động theo kiểu kdl đó
             */
            int a = 5, b = 7;
            double c =1.2 , d= 5.6;
            Swap<int>(ref a, ref b); // gọi hàm lên thì phải truyền kdl vào 
            Swap<double>(ref c, ref d);

            #endregion
            #region Generic cho lớp
            Generic<int> MyGeneric = new Generic<int>(5);
            MyGeneric.SetItemValue(0, 10);
            #endregion
        }

    }
}
