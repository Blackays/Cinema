using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dich
{
    class Customer
    {

        int Id = 1;
        private string Name { get; set; }
        private string SurName { get; set; }
        private int age { get; set; }
        string login { get; set; }
        string password { get; set;}
        private string rights { get; set; }
        Customer[] customers = new Customer[100];

        public void Creation()
        {
            for (int i = 1; i < 100; i++)
            {
                customers[i] = new Customer();
            }
        }

        public void SignIn()
        {
            Console.WriteLine("Введіть логін:\n");
            string login = Console.ReadLine();
            Console.WriteLine("Введіть пароль:\n");
            string password = Console.ReadLine();
            Console.WriteLine("Введіть ім'я:\n");
            string name = Console.ReadLine();
            Console.WriteLine("Введіть прізвище:");
            string surname = Console.ReadLine();
            Console.WriteLine("Введіть вік:");
            int age = Convert.ToInt32(Console.ReadLine());
            customers[Id] = new Customer();
            customers[Id].password = password;
            customers[Id].login = login;
            customers[Id].Name = name;
            customers[Id].SurName = surname;
            customers[Id].age = age;
            customers[Id].rights = "user";
            Console.WriteLine($"Аккаунт № {Id} успiшно створенно");
            Id++;
        }
        public int LogIn()
        {
            Console.Read();
            Console.WriteLine("Введіть логін:");
            string login = Console.ReadLine();
            Console.WriteLine("Введіть пароль:");
            string password = Console.ReadLine();
            for (int i = 1; i < 100; i++)
            {
                if (customers[i].login == login)
                {
                    if (customers[i].password == password)
                    {
                        Console.WriteLine($"{customers[i].Name}, ви успiшно зайшли ");
                        this.Id = i;
                        return i;
                    }
                    else
                    {
                        Console.WriteLine("Неправильний пароль, попробуйте знову");
                        return 0;
                    }                   
                }
            }
       
            Console.WriteLine("Данний аккаун не був створений");
            return 0;     
        }
        public void Profile()
        {
            mitka:
            Console.Clear();
            Console.WriteLine($"Iм'я: {customers[Id].Name}\n");
            Console.WriteLine($"Прiзвище: {customers[Id].SurName}\n");
            Console.WriteLine($"Вiк: {customers[Id].age}\n\n");
            Console.WriteLine("1-Повернутись в меню\n");
            Console.WriteLine("2-Змiнити iм'я\n");
            Console.WriteLine("3-Змiнити прiзвище\n");
            Console.WriteLine("4-Змiнити вiк\n");
            string k = Console.ReadLine();
            switch(k)
            {
                case "1":
                    Console.Clear();
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("Введіть ім'я:\n");
                    string name = Console.ReadLine();
                    customers[Id].Name = name;
                    goto mitka;
                case "3":
                    Console.Clear();
                    Console.WriteLine("Введіть ім'я:\n");
                    string surname = Console.ReadLine();
                    customers[Id].SurName = surname;
                    goto mitka;
                    
                case "4":
                    Console.Clear();
                    Console.WriteLine("Введіть ім'я:\n");
                    int aGe = Convert.ToInt32(Console.ReadLine());
                    customers[Id].age = aGe;
                    goto mitka;

            }

        }
        
        public Customer()
        { }
        public Customer(string login,string password,string name,string Surname,int age,string rights)
        {
            this.login = login;
            this.password = password;
            Name = name;
            SurName = Surname;
            this.age = age;
            this.rights = rights;
        }
    }
}
