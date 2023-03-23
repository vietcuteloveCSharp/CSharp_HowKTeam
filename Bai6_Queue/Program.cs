using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Bai6_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            #region Khai báo và khởi tạo  Queue
            Queue MyQueue = new Queue(); //khởi tạo 1 Stack rỗng
            Queue MyQueue2 = new Queue(5); // khởi tạo 1 Stack và chỉ định sức chứaban đầu là 5 

            //khởi tạo 1 mảng bất kì
            ArrayList MyArray = new ArrayList();
            MyArray.Add(5);
            MyArray.Add(9);
            MyArray.Add(10);
            //khởi tạo 1 Stack và sao chép giá trị của các phần tử MyArray vào Stack
            Queue MyQueue3 = new Queue(MyArray);
            #endregion
            #region Sử dụng Queue
            //tạo 1 stack rỗng
            Queue MyQueue4 = new Queue();

            //thực hiện thêm vài phần tử vào Stack thông qua hàm Push
            MyQueue4.Enqueue("edu");
            MyQueue4.Enqueue("edu2");
            MyQueue4.Enqueue("edu3");

            //thử sử dụng các phương thức của stack
            Console.WriteLine("Số phần tử hiện tại là:" + MyQueue4.Count);

            //lưu ý ở đây ta chỉ muốn xem giá trị mà không muốn nó ra khỏi Stack thì ta sẽ dùng Peek
            Console.WriteLine("Phần tử đầu của Stack" + MyQueue4.Peek());

            //Thử kiểm tra lại số phần tử để chắc chắn rằng hàm Peek không xoá phần tử ra khỏi Stack
            Console.WriteLine("Spps phần tử của Stack sau khi gọi hàm Peek:" + MyQueue4.Count);

            //thực hiện xoá các phần tử ra khỏi Stack
            Console.WriteLine("Xoá---");
            int Length = MyQueue4.Count;
            for (int i = 0; i < Length; i++)
            {
                Console.WriteLine(" " + MyQueue4.Dequeue());
            }
            // Kiểm tra lại số phần tử của Strack sau khi Pop
            Console.WriteLine("Số phần tử sau khi Pop:" + MyQueue4.Count);
            #endregion
        }
    }
}
