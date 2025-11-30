namespace Program
{


    class SignIn
    {
        string username = "N/A";
        string password = "N/A";
        string name = "N/A";
        string lastname = "N/A";
        int age = 0;




        public void Register()
        {

            Console.Write(" Type your name => ");
            name = Console.ReadLine();

            Console.Write("\n");


            Console.Write(" Type your lastname => ");
            lastname = Console.ReadLine();

            Console.Write("\n");


            Console.Write(" Type your age => ");
            age = Int32.Parse(Console.ReadLine());

            Console.Write("\n");



            string upperLastname = lastname.ToUpper();
            string firstTwoLetters = name.Substring(0, 2).ToLower(); 

            username = upperLastname + "_" + age + "_" + firstTwoLetters;


            password = GeneratePassword();


            Console.Write("\n\n Registration successful!\n\n");
            Console.Write($" Username => {username}\n");
            Console.Write($" Password => {password}\n");





        }

        
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



        public string GetUsername()
        {
            return username;
        }

        public string GetPassword()
        {
            return password;
        }












    }





    class Login
    {


        int attempts = 3;


        public bool Authenticate(string username, string password)
        {

            while (attempts > 0)
            {

                Console.Write("\n\n Type username => ");

                string intputusername = Console.ReadLine();

                Console.Write("\n");


                Console.Write(" Type password => ");

                string intputpassword = Console.ReadLine();

                Console.Write("\n");


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















    class Program
    {
        static void Main()
        {

            string savedusername = null;
            string savedpassword = null;


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
                        SignIn signIn = new SignIn();
                        signIn.Register();
                        savedusername = signIn.GetUsername();
                        savedpassword = signIn.GetPassword();


                        break;



                    case "2":


                        if (savedusername == null)
                        {
                            Console.Write("No registered users!\n");
                        }


                        else
                        {
                            Login login = new Login();
                            login.Authenticate(savedusername, savedpassword);
                        }
                        break;



                    default:
                        Console.Write("\n Invalid option\n");
                        break;
                }


            }





        }
    }





}
