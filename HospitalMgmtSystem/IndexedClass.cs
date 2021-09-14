using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalMgmtSystem
{
    interface IUser
    {
        int a { get; set; }
        void work();
    }

    class User: IUser
    {
        public int a { get => a; set => a = value; }
        public void work()
        {

        }
    }
    class IndexedClass
    {
        private string[] names = new string[10];

        const int a = 10; // must have value initially
        readonly int b; // can assign value in constructor

        IndexedClass()
        {
            b = 20;
        }
        public string this[int index]
        {
            get
            {
                return (index >= 0 && index <= 9) ? names[index] : "Invalid";
            }
            set
            {
                if (index >= 0 && index <= 9)
                {
                    names[index] = value;
                }
            }
        }
        public int this[string name]
        {
            get
            {
                int index = 0;
                while(index < 10)
                {
                    if(names[index] == name)
                    {
                        return index;
                    }
                    index++;
                }
                return -1;
            }
        }
        static void Main(string[] args)
        {
            IndexedClass nameList = new IndexedClass();
            nameList[0] = "John";
            nameList[1] = "Smith";
            Console.WriteLine(nameList[0]);
            Console.WriteLine(nameList[10]);
            Console.WriteLine(nameList["Smithh"]);
        }
    }
}
