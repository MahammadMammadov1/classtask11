using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask.Models
{
    internal  static class UserService
    {
        public static void Register(string name, string surname, string password) 
        { 
            
        }
      
        public static bool Login(string username, string password)
        {
            foreach (var item in BlogDatabase.UserList)
            {
                if(item.UserName == username && item.Password == password)
                {
                    Console.WriteLine("Giris olundu");
                    return true;
                }
            }return false;
        }

        
    }
}
