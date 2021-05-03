using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var list1 = new GenericListTester<string>();
            list1.GenericList.Add("Jos");
            list1.GenericList.Add("Jefke");
            list1.GenericList.Add("Paul");

            list1.ToonInfo();


            var list2 = new GenericListTester<Student>();
            list2.GenericList.Add(new Student());
            list2.GenericList[0].Naam = "Firmin";
            list2.GenericList.Add(new Student());
            list2.GenericList[1].Naam = "Michel";

            list2.ToonInfo();
        }
    }
}
