using System.Reflection.Metadata;
using System.Xml.Linq;

namespace Program
{


    class SignIn
    {
        protected string username = "N/A";
        protected string password = "N/A";
        string name = "N/A";
        string lastname = "N/A";
        int age = 0;


        string GeneratePassword()
        {


            Random random = new Random();

            string allLetters = "abcdefghijABCDEFGHIJKLMNOklmnopqrstuvwxyzPQRSTUVWXYZ";


            string newpassword = "";


            int lenght = 10;

            for (int i = 0; i < 10; i++)
            {
                int randomPosition = random.Next(allLetters.Length);

                char randomLetters = allLetters[randomPosition];

                newpassword += randomLetters;


            }

            return newpassword;





        }


        public void Register(string name, string lastname, int age)
        {

            



            string upperLastname = lastname.ToUpper();
            string firstTwoLetters = name.Substring(0, 2).ToLower();

            username = upperLastname + "_" + age + "_" + firstTwoLetters;


            password = GeneratePassword();


            Console.Write("\n\n Registration successful!\n\n");
            Console.Write($" Username => {username}\n");
            Console.Write($" Password => {password}\n");


            





        }



       



        protected string GetUsername()
        {
            return username;
        }

        protected string GetPassword()
        {
            return password;
        }












    }





    class Login : SignIn
    {

        int attempts = 3;



       

        public bool Authenticate(string intputusername, string intputpassword)
        {

            while (attempts > 0)
            {

               


                if (intputusername == username && intputpassword == password)
                {
                    Console.Write("\n Login successful\n");
                    return true;
                }


                else
                {
                    attempts--;

                    Console.Write("\n401 (Unauthorized)\n");
                }









            }

            Console.Write("\n");

            Console.Write("Account blocked! Too many failed attempts!\n");

            return false;


        }

    }



    class RunSystem : Login
    {

        

        public void Run()
        {
            while (true)
            {
                Console.Write(" \n 1. Sign In\n");
                Console.Write(" 2. Log In\n");
                Console.Write("\n");
                Console.Write(" Select option => ");

                string choice = Console.ReadLine();

                switch (choice)
                {


                    case "1":
                        


                        Console.Write("\n Type your name => ");
                        String name = Console.ReadLine();

                        Console.Write("\n");


                        Console.Write(" Type your lastname => ");
                        String lastname = Console.ReadLine();

                        Console.Write("\n");


                        Console.Write(" Type your age => ");
                        int age = Int32.Parse(Console.ReadLine());

                        Console.Write("\n");

                        Register(name, lastname, age);

                        



                        break;



                    case "2":


                        if (username == "N/A" && password == "N/A")
                        {
                            Console.Write("No registered users!\n");
                        }


                        else
                        {
                            

                            Console.Write("\n\n Type username => ");

                            string intputusername = Console.ReadLine();

                            Console.Write("\n");


                            Console.Write(" Type password => ");

                            string intputpassword = Console.ReadLine();

                            Console.Write("\n");

                            Authenticate(intputusername, intputpassword);
                        }
                        break;



                    default:
                        Console.Write("\n Invalid option\n");
                        break;
                }


            }
        }
        

}














    class Program
    {
        static void Main()
        {

            


            RunSystem r = new RunSystem();

            r.Run();




        }
    }





}
