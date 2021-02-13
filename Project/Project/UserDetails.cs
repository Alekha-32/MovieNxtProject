using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
   public class UserDetails
    {
      
        public void userLogin()
        {
            Boolean isregister = true;
            usersInfo usersInfoObj = new usersInfo();
            while (isregister)
            {
                Console.WriteLine("1: Register New Account ");
                Console.WriteLine("2: Login with existing userName and password");

                int userOption = Convert.ToInt32(Console.ReadLine());
                switch(userOption)
                {
                    case 1:
                        Console.WriteLine("Enter your user name :");
                        usersInfoObj.NameUser = Console.ReadLine();
                        Console.WriteLine("Enter your fullName :");
                        usersInfoObj.FullName = Console.ReadLine();
                        Console.WriteLine("Enter your Email Id ");
                        usersInfoObj.Email = Console.ReadLine();
                        Console.WriteLine("Enter your phone no :");
                        usersInfoObj.mobileNo = Convert.ToInt64(Console.ReadLine());
                        Console.WriteLine("Enter your password :");
                        usersInfoObj.password = Console.ReadLine();

                        try
                        {
                            using (movieNxxDBContext dBContext = new movieNxxDBContext())
                            {

                                dBContext.usersInfoes.Add(usersInfoObj);
                                dBContext.SaveChanges();
                                Console.WriteLine("Registration successfull");
                            }

                        }
                        catch (EntityException ex)
                        {
                            Console.WriteLine("you have missed some filed, Try Again !!! " + ex);
                        }
                        break;
                    case 2:

                        Console.WriteLine("Enter your valid userName :");
                        string userName = Console.ReadLine();
                        Console.WriteLine("Enter your password :");
                        string password = Console.ReadLine();
                        using (movieNxxDBContext dBContext = new movieNxxDBContext())
                        {
                            var result = from s in dBContext.usersInfoes select s;
                            foreach (usersInfo usersInfo in result)
                            {
                                if (usersInfo.NameUser.Equals(userName) && usersInfo.password.Equals(password))
                                {
                                    Console.WriteLine("Login Successfull");
                                    listOfMovies();

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

        public static void listOfMovies()
        {
            Console.WriteLine("********************************************");
            Console.WriteLine("Search your favorite movies :");
            Console.WriteLine("1:Title of the movie");
            Console.WriteLine("2:Search Actor Name or Actress Name ");
            Console.WriteLine("3:Genre");
            Console.WriteLine("4:Duration of the movie");
            Console.WriteLine("5:Plot keyWords");
            Console.WriteLine("6: Exit");
            int movieOption = Convert.ToInt32(Console.ReadLine());
            switch(movieOption)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                default:
                    break;
            }
        }
    }
}
