using Sanch.StructuraData_HashTable.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanch.StructuraData_HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            #region BadHashTable
            //var badHashTable = new BadHashTable<int>(100);
            //badHashTable.Add(5);
            //badHashTable.Add(18);
            //badHashTable.Add(777);
            //badHashTable.Add(7);

            //Console.WriteLine(badHashTable.Search(6));
            //Console.WriteLine(badHashTable.Search(18));
            #endregion

            #region MyHashTable
            //var myHashTable = new MyHashTable<int, string>(100);
            //myHashTable.Add(5,"Привет");
            //myHashTable.Add(18, "Мир");
            //myHashTable.Add(777, "Здравствуй");
            //myHashTable.Add(7, "Программист");

            //Console.WriteLine(myHashTable.Search(6, "Вася"));
            //Console.WriteLine(myHashTable.Search(18, "Мир"));
            #endregion

            #region SuperHashTable
            var superHashTable = new SuperHashTable<Person>(100);
            var person = new Person() { Name = "Вася", Age = 25, Gender = 0 };
            superHashTable.Add(new Person() { Name = "Петя", Age = 35, Gender = 0 });
            superHashTable.Add(new Person() { Name = "Андрей", Age = 15, Gender = 0 });
            superHashTable.Add(new Person() { Name = "Катя", Age = 18, Gender = 1 });
            superHashTable.Add(person);
            

            Console.WriteLine(superHashTable.Search(new Person() { Name = "Вася", Age = 25, Gender = 0 }));
            Console.WriteLine(superHashTable.Search(person));
            #endregion

            Console.ReadLine();

        }
    }
}
