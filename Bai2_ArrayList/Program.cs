using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Bai2_ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ArrayList định nghĩa

            #endregion
            #region Khởi tạo ArrayList
            //ArrayList MyArray = new ArrayList(); // khởi tạo 1 ArrayList rỗng
            //ArrayList MyArray2 = new ArrayList(5); // khởi tạo 1 ArrayList và chỉ định Capacity ban đầu là 5
            ///*
            // * khởi tạo 1 ArrayList có kích thước bằng với MyArray2
            // * Sao chép toàn bộ phần tử trong MyArray2 và MyArray3
            // * 
            // */
            //ArrayList MyArray3 = new ArrayList(MyArray2); // clone ra 1 ArrayList mới và xin cấp phát vùng nhớ mới = vùng nhớ của MyArray2

            #endregion
            #region Sắp xếp 1 danh sách obj trong ArrayList
            // tạo 1 danh sách kiểu ArrayList rỗng
            ArrayList arrPersons = new ArrayList();
            //thêm 3 person vào danh sách
            arrPersons.Add(new Person("Nguyễn Văn A", 19));
            arrPersons.Add(new Person("Nguyễn Văn B", 18));
            arrPersons.Add(new Person("Nguyễn Văn C", 20));
            // In thử danh sách Person ban đầu ra
            Console.WriteLine("Danh sách person ban đầu");
            foreach (var item in arrPersons)
            {
                Console.WriteLine(item.ToString());
            }
            /*
             * Thự hiện sắp xếp danh sách Person theo tiêu chí đã định nghĩa
             * Trong phương thức Compare của lớp SortPerson (tuổi tăng dần)
             */
            arrPersons.Sort(new SortPersons());
            //in ra danh sách đã được sắp xếp in ra mình
            Console.WriteLine();
            Console.WriteLine("Dan sách person đã được sắp sếp theo tuổi giảm dần");
            foreach (var item in arrPersons)
            {
                Console.WriteLine(item.ToString());
            }
            #endregion
            Console.ReadLine();
        }
    }
    public class SortPersons : IComparer
    {
        public int Compare(object x, object y)
        {
            
            // ép kiểu 2 obj truyền vào về person
            Person p1 = x as Person;
            Person p2 = y as Person;
            /*
             * Vì có thể 2 obj truyền vào không phải person khi đó ta không thể so sánh được
             * Trường hợp này tốt nhất ta nên ném ra lỗi để LTV sửa chữ
             * Chi tiết về exception sẽ được trình bày ở những bài học sau
             */
            if (p1 == null || p2 == null)
            {
                throw new InvalidCastException();
            }
            else
            {
                /*
                 *Khi dữ liệu đã ok thì ta thực hiện so sánh và trả về các giá trị 1 0 -1 tương ứng , lớn hơn ,bằng ,bé hơn
                 */
                if (p1.Age < p2.Age)
                {
                    return 1;
                }
                else if (p1.Age > p2.Age)
                    return -1;
                else return 0;
            }
        }

    }
}
    
