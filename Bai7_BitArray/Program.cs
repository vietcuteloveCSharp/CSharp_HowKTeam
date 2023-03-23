using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Bai7_BitArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            #region BitArray
            // BitArray: giúp quản lý, kưu trữ 1 danh sách các bit ( 0 va 1) , được kiểu diễn kiểu bool . True = bit 1 và false = bit 0
            // không thể khởi tạo BitArray rỗng 

            // khởi tạo 1 BitArray có 10 phần tử
            // mỗi phần tử có giá tị mặc định 0 (false)
            BitArray MyBit = new BitArray(10);

            // khởi tạo 1 BitArray có 10 phần tử
            // mỗi phần tử có giá tị mặc định 1 (true)
            BitArray MyBit1 = new BitArray(10, true);

            /*
             * Khởi tạo 1 BitArray từ 1 mảng bool có sẵn
             */
            bool[] MyBool = new bool[5] { true, false, false, true, true };
            BitArray MyBit3 = new BitArray(MyBool); // 1 0 0 1 1

            /*
             * Khởi tạo 1 BitArray từ 1 mảng byte có sẵn
             */
            byte[] MyByte = new byte[5] { 1, 2, 3, 4, 5 };
            BitArray MyBit4 = new BitArray(MyByte);

            //Kiểm thử, Uncommment để xem kết quả
            Console.WriteLine("Số bit của BitArray la" + MyBit4.Count);
            PrintBits(MyBit4, 8);
            
            #endregion
        }
        public static void PrintBits(BitArray MyBA, int Width)
        {
            int i = Width;
            foreach (bool item in MyBA)
            {
                if (i<1)
                {
                    i = Width;
                    Console.WriteLine();
                }
                i--;
                Console.WriteLine(item.GetHashCode());
            }
            Console.WriteLine();
        }
    }
}
