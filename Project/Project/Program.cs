using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
   public class Program
    {


        public void displayOption()
        {
            AdminDetails adminDetailsObj = new AdminDetails();
            UserDetails userDetailsObj = new UserDetails();
            while (true)
            {
                Console.WriteLine("Select your option :");
                Console.WriteLine("1:Admin");
                Console.WriteLine("2:User");
               

                int userOption = Convert.ToInt32(Console.ReadLine());
                switch(userOption)
                {
                    case 1:
                        adminDetailsObj.register();
                        break;
                    case 2:
                        userDetailsObj.userLogin();
                        break;
                }
            }

        }
       public static void Main(string[] args)
        {
            Program programObj = new Program();
            programObj.displayOption();
        }
    }
}
