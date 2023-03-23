using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3_HashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //#region  khởi tạo HashTable(cặp key-value)
            //// lưu ý : hashtable không thể sử dụng index . chỉ sử dụng key -value
            //Hashtable MyHash = new Hashtable(); // khởi tạo 1 Hashtable rỗng
            //Hashtable MyHash2 = new Hashtable(5); // khởi tạo 1 Hashtable và chỉ định Capactity ban đầu là 5
            //MyHash.Add("k", "kteam");
            //MyHash2.Add("fe", "Education");
            ///*
            // * Khởi tạo 1 Hashtable có kích thước bằng với MyHash2
            // * SAo chéo toàn bộ phần tử trong MyHash2 vào MyHash3
            // */
            //Hashtable MyHash3 = new Hashtable(MyHash2);
            //#endregion
            #region Một số lưu ý về Hashtable
            /*
             * Mỗi 1 phần tử trong hashtable (key-value) được định nghĩa là 1 đối tượng kiểu DictionaryEntry . Và trong DictionaryEntry Có 2 thuộc tính chính (key:trả về keycủa phần tử hiện tại) (value: Trả về value của phần tử hiện tại)
             */
            //Tạo 1 Hashtable đơn giản với 3 phần tử
            Hashtable hash = new Hashtable();
            hash.Add("k", "kteam");
            hash.Add("h", "howkteam");
            hash.Add("fe", "feducation");
            //truy xuất theo key
            //Console.WriteLine(hash["h"]);

            /*
             * Duyệt qua các phần tử trong hashtable
             * vì mỗi 1 phần tử là 1 DictionaryEntry nên ta chỉ có kiểu dữ liệu cho item là DictionaryEntry luôn
             * Un ra màn hình cặp key- value của mỗi phần tử được duyệt
             */
            //foreach (DictionaryEntry item in hash)
            //{
            //    Console.WriteLine(item.Key + "\t" + item.Value);
            //}

            //lưu ý:truy xuất trong hashtable thông qua key - Nếu giá trị không tồn tại --> null  chứ không báo lỗi 
            if (hash["Vt"]==null)
            {
                Console.WriteLine("check lưu ý trên");
            }

            //in ra số phần tử đầu tiên của Hashtable
            Console.WriteLine("Số phần tử:"+hash.Count);
            foreach (DictionaryEntry item in hash)
            {
                Console.WriteLine(item.Key +"  "+item.Value);
            }
            //thực hiện gán giá tị 1 key không tồn tại
            hash["KT"] = "kter";
            hash["K9"] = "kim long";
            //thực hiện in lại số phần tử của hashtable để thấy sự thay đổi
            Console.WriteLine("Số phần tử"+hash.Count);
            foreach (DictionaryEntry item in hash)
            {
                Console.WriteLine(item.Key + "  " + item.Value);
            }
            #endregion
        }
    }
}