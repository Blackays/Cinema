using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace dich
{
    class Program : Customer
    {
        static void Main(string[] args)
        {
            bool b = false , j=false;          
            Customer Just = new Customer();
            Just.Creation();
            mitka:
            Console.WriteLine("Доброго дня!\n");
            Console.WriteLine("1-Ввiiйти в систему\n");
            Console.WriteLine("2-Зареєструватись\n");
            Console.WriteLine("3-Ввiйти в систему вiд iменi адмiнiстратора");
            if (b != false)
            {
                Console.ReadLine(); 
            }
            b = true;
            string k = Console.ReadLine();
            switch (k)
            {
                case "1":
                    int nd = Just.LogIn();
                    if (nd == 0)
                    {
                        Console.WriteLine("Попробуйте знову!");
                        goto mitka;
                    }
                    else
                    {
                        goto mitka1;
                    }

                case "2":
                    Just.SignIn();
                    goto mitka;

                case "3":
                    goto mitka1;
            }
            mitka1:
            Console.WriteLine("Доброго дня!\n");
            Console.WriteLine("1-Профiль\n");
            Console.WriteLine("2-Фiльми цього тижня\n");
            Console.WriteLine("3-Фiльми сьогоднi\n");
            Console.WriteLine("4-Пошук фiльмiв за годинною\n");
            Console.WriteLine("5-Пошук фiльмiв по назвi\n");
            Console.WriteLine("6-\n");
            //if (j != false)
            //{
            //    Console.ReadLine();
            //}
            //j = true;
            k = Console.ReadLine();
            
            switch (k)
            {
                case "1":
                    Just.Profile();
                    goto mitka1;
                case "2":
                    
                case "3":

                case "4":

                case "5":

                case "6":

                    break;
                   
            }

            return;
        }
    }
}
