using ClassTask.Models;
using System.Xml.Linq;

namespace ClassTask
{
    internal class Program
    {
       

        static void Main(string[] args)
        {

            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine("<======== Menu ========>");
            Console.WriteLine("1. Register");
            Console.WriteLine("2. Login");

            switch (choice)
            {
                case 1:
                    UserService.Register(CreateReg());
                    break;
                case 2:
                    do
                    {

                        Console.WriteLine("Enter UserName : ");
                        string userName = Console.ReadLine();
                        Console.WriteLine("Enter Password : ");
                        string passWord = Console.ReadLine();

                    } while (UserService.Login(userName, passWord) = true);
                    break;
            }


            int choice2=int.Parse(Console.ReadLine());

        }

        


        static void CreateReg()
        {
            Console.WriteLine("Enter Name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter SurName : ");
            string surname = Console.ReadLine();
            Console.WriteLine("Enter PassWord : ");
            string password = Console.ReadLine();

            
   
        }
        
    }
}