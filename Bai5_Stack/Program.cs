using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5_Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding =Encoding.UTF8;
            #region Khai báo và khởi tạo  Stack
            Stack MyStack = new Stack(); //khởi tạo 1 Stack rỗng
            Stack MyStack2 = new Stack(5); // khởi tạo 1 Stack và chỉ định sức chứaban đầu là 5 

            //khởi tạo 1 mảng bất kì
            ArrayList MyArray = new ArrayList();
            MyArray.Add(5);
            MyArray.Add(9);
            MyArray.Add(10);
            //khởi tạo 1 Stack và sao chép giá trị của các phần tử MyArray vào Stack
            Stack MyArray3 = new Stack(MyArray);
            #endregion
            #region Sử dụng Stack
            //tạo 1 stack rỗng
            Stack MyStack4 = new Stack();

            //thực hiện thêm vài phần tử vào Stack thông qua hàm Push
            MyStack4.Push("edu");
            MyStack4.Push("edu2");
            MyStack4.Push("edu3");

            //thử sử dụng các phương thức của stack
            Console.WriteLine("Số phần tử hiện tại là:" + MyStack4.Count);

            //lưu ý ở đây ta chỉ muốn xem giá trị mà không muốn nó ra khỏi Stack thì ta sẽ dùng Peek
            Console.WriteLine("Phần tử đầu của Stack" + MyStack4.Peek());

            //Thử kiểm tra lại số phần tử để chắc chắn rằng hàm Peek không xoá phần tử ra khỏi Stack
            Console.WriteLine("Spps phần tử của Stack sau khi gọi hàm Peek"+MyStack4.Count);

            //thực hiện xoá các phần tử ra khỏi Stack
            Console.WriteLine("Xoá---");
            int Length = MyStack4.Count;
            for (int i = 0; i < Length; i++)
            {
                Console.WriteLine(" "+ MyStack4.Pop());
            }
            // Kiểm tra lại số phần tử của Strack sau khi Pop
            Console.WriteLine("Số phần tử sau khi Pop:"+ MyStack4.Count);
            #endregion
        }
    }
}
