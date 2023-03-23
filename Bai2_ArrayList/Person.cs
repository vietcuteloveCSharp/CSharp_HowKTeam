using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2_ArrayList
{
    internal class Person
    {
        private string name;
        private int age;
        public string Name { get { return name; } set { name = value; } }
        public int Age { get { return age; } set { age = value; } }
        // tạo 1 contructor có tham số 
        public Person (string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public override string ToString()
        {
            return "name" + Name + " " + " age:" + Age;
        }
    }
}
