using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
  public  class AdminDetails
    {

      public void register()
        {
            AdminInfo adminInfoObj = new AdminInfo();
           Boolean Isboolean = true;
            while (Isboolean)
            {
                Console.WriteLine("1:Register new Admin ");
                Console.WriteLine("2:Login");
                int userOption = Convert.ToInt32(Console.ReadLine());
                switch(userOption)
                {
                    
                    case 1:
                        Console.WriteLine("Enter your UserName:");
                        adminInfoObj.userName = Console.ReadLine();
                        Console.WriteLine("Enter your firstName:");
                       adminInfoObj.firstName = Console.ReadLine();
                        Console.WriteLine("Enter your lastName :");
                        adminInfoObj.lastName = Console.ReadLine();
                      
                        Console.WriteLine("Enter your emailId :");
                        adminInfoObj.Email = Console.ReadLine();
                        Console.WriteLine("Enter your mobile Number :");
                        adminInfoObj.PhoneNo = Convert.ToInt64(Console.ReadLine());
                        Console.WriteLine("Enter your password :");
                         adminInfoObj.password = Console.ReadLine();
                     
                       try
                        {
                            using(movieNxxDBContext dBContext = new movieNxxDBContext())
                            {

                                dBContext.AdminInfoes.Add(adminInfoObj);
                                dBContext.SaveChanges();
                                Console.WriteLine("Registration successfull");
                            }
                            
                        }
                        catch(EntityException ex )
                        {
                            Console.WriteLine("you have missed some filed, Try Again !!! " + ex);
                        }
                        
                        break;
                    case 2:

                        Console.WriteLine("Enter your valid UserName :");
                        string userName = Console.ReadLine();
                        Console.WriteLine("Enter your password :");
                        string password = Console.ReadLine();
                        using(movieNxxDBContext dBContext = new movieNxxDBContext())
                        {
                            var result = from s in dBContext.AdminInfoes select s;
                           foreach(AdminInfo adminObj in result)
                            {
                                if(adminObj.userName.Equals(userName) && adminObj.password.Equals(password))
                                {
                                    Console.WriteLine("Login Successfull");
                                    adminOperation();
                                    
                                }
                                else
                                {
                                    Console.WriteLine("Incorrect userName and password , Enter correct UserName and password");
                                    
                                }
                            }
                        }
                        

                        break;
                    
                }
            }
         
        }

        public static void adminOperation()
        {

            Boolean isboolean = true;
            while(isboolean)
            {
                Console.WriteLine("****************************");
                Console.WriteLine("1: Add Movie Details");
                Console.WriteLine("2: Update movie Details");
                Console.WriteLine("3: Delete Movie Detaisl");

                int adminOption = Convert.ToInt32(Console.ReadLine());
                switch(adminOption)
                {
                    case 1:

                break;
                    case 2:
                        break;
                    case 3:
                        break;
                    default:
                        break;
                }

            }
        }
    }
}
