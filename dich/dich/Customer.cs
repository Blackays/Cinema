
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dich
{
    class Customer
    {
        public int Id { get; set; } = 1;
        public string Name { get; set; }
        public string SurName { get; set; }
        public int age { get; set; }
        public string login { get; set; }
        public string password { get; set;}
        

        //public void SignIn()
        //{
        //    Console.WriteLine("Введiть логiн:\n");
        //    this.login = Console.ReadLine() ;
        //    Console.WriteLine("Введiть пароль:\n");
        //    this.password = Console.ReadLine();
        //    Console.WriteLine("Введiть iм'я:\n");
        //    this.Name = Console.ReadLine();
        //    Console.WriteLine("Введiть прiзвище:");
        //    this.SurName = Console.ReadLine();
        //    Console.WriteLine("Введiть вiк:");
        //    this.age = Convert.ToInt32(Console.ReadLine()); ;
        //    this.rights = "user";
        //    Console.Clear();
        //    Console.WriteLine("Аккаунт успiшно створенно");
        //    Id++;
           
        //}
        
        //public void Profile()
        //{
        //    mitka:
        //    Console.Clear();
        //    Console.WriteLine($"Iм'я: {this.Name}\n");
        //    Console.WriteLine($"Прiзвище: {this.SurName}\n");
        //    Console.WriteLine($"Вiк: {this.age}\n\n");
        //    Console.WriteLine("1-Повернутись в меню\n");
        //    Console.WriteLine("2-Змiнити iм'я\n");
        //    Console.WriteLine("3-Змiнити прiзвище\n");
        //    Console.WriteLine("4-Змiнити вiк\n");
        //    string k = Console.ReadLine();
        //    switch(k)
        //    {
        //        case "1":
        //            Console.Clear();
        //            break;
        //        case "2":
        //            Console.Clear();
        //            Console.WriteLine("Введiть нове iм'я:\n");
        //            this.Name = Console.ReadLine();
        //            goto mitka;
        //        case "3":
        //            Console.Clear();
        //            Console.WriteLine("Введiть нове прiзвище:\n");
        //            this.SurName = Console.ReadLine();
        //            goto mitka;
                    
        //        case "4":
        //            Console.Clear();
        //            Console.WriteLine("Введiть свiй вiк:\n");
        //            this.age = Convert.ToInt32(Console.ReadLine());
        //            goto mitka;

        //    }

        //}
        
        //public Customer()
        //{ }
        //public Customer(string login,string password,string name,string Surname,int age,string rights)
        //{
        //    this.login = login;
        //    this.password = password;
        //    this.Name = name;
        //    this.SurName = Surname;
        //    this.age = age;
        //    this.rights = rights;
        //}
    }
}
