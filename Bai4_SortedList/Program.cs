using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4_SortedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region SortedList
            // đặc điểm là 1 hashtable nhưng các giá trị sắp xếp theo key . SortedList có thể truy suất đến các phần tử thông qua key như HashTable hoặc thông qua chỉ số phần tử như ArrayList (sự kết hợp của HashTable vs ArrayList
            SortedList MySort = new SortedList(); // khởi tạo 1 SortedList rỗng
            SortedList MySort2 = new SortedList(5); // khởi tạo 1 Hashtable và chỉ định Capactity ban đầu là 5
            MySort.Add("k", "kteam");
            MySort2.Add("fe", "Education");
            /*
             * Khởi tạo 1 SortedList có kích thước bằng với MySort2
             * SAo chéo toàn bộ phần tử trong MyHash2 vào MySort3
             */
            SortedList MySort3 = new SortedList(MySort2);
            SortedList MySort4 = new SortedList(new PersonComparer());
            /*
             * Tạo 1 SortedList mới và sao chép các phần  tử từ MySort3 đồng thời sắp xếp lại theo cách sắp xếp được định nghĩa trong  class PersonComparer
             * 
             */
            SortedList MySort5 = new SortedList(MySort3, new PersonComparer());

            #endregion
            #region Ví dụ sử dung
            //tạo 1 SortedList và truyền vào cách sắp sếp các key trong SortedList này
            SortedList MySort6 = new SortedList(new PersonComparer());
            MySort6.Add(new Person1("Kteam", 20), 15);
            MySort6.Add(new Person1("kteam", 15), 10);
            foreach (DictionaryEntry item in MySort6)
            {
                Console.WriteLine("Key:"+item.Key+"  "+ "Value:"+item.Value);
            }
            #endregion
        }
    }
    // Định nghĩa 1 lớp thực thi interface IComparer
    // override phương thức Compare và định sắp xếp trong đó
    // Quên thì xem lại ở ArrayList
    class PersonComparer :IComparer
    {
        public int Compare(object x, object y)
        {
            Person1 p1 = (Person1)x; // x as person1
            Person1 p2 = (Person1)y;
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
