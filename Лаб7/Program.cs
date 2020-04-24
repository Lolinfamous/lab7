using System;

namespace Лаб7
{
    class Program
    {
        class Example
        {
            private string fam, status;
            private int salary, age;
            public string Fam
            {
                set { if (fam == "") fam = value; }
                get { return (fam); }
            }

            public int Age
            {
                set { age = value; }
                get { return (age); }
            }

            public string Status
            {
                get { return (status); }
            }

            public int Salary
            {
                set { salary = value; }
            }   

            private string helth;
            public Example()
            {
                this.fam = "";
                this.helth = "Алкоголик";
                this.status = "Холост";
            }
            public int get_salary()
            {
                return this.salary;
            }

            public string get_helth()
            {
                return this.helth;
            }

        }
        static void Main()
        {
            Example c = new Example();
            c.Fam = "Кукса";
            c.Fam = "hggj";
            c.Salary = 49950;
            c.Age = 22;
            Console.WriteLine("Фамилия = {0}, статус = {1}, зарплата = {2}, возраст = {3}, здоровье = {4}", c.Fam, c.Status, c.get_salary(), c.Age, c.get_helth());
        }
    }
}
