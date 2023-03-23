using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai8_Generic
{
    public class Generic<T>
    {
        private T[] items;
        public T[] Items
        {
            get { return items; }
        }
        public Generic(int size) // khởi tạo size theo size mình sử dụng
        {
            items = new T[size];
        }
        public T GetByIndex(int index) //Lấy item theo index truyền vào
        {
            // nếu index vượt ra khỏi chỉ số phần tử của mảng thì ném ra ngoại lệ
            if (index < 0 || index >= items.Length)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                return items[index];
            }
        }
        public void SetItemValue(int index, T value) // lấy giá trị theo index truyền vào
        {
            if (index < 0 || index >= items.Length)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                items[index] = value;
            }

        }
    }
}
