using System.Security.Principal;

namespace Program

{



    #region 1

    interface IPrintable

    {

        void Print();



    }

    class Book : IPrintable

    {

        public string Title { get; set; } = string.Empty;

        public string Author { get; set; } = string.Empty;

        public int Pages { get; set; }

        public double Price { get; set; }


        public override string ToString()

        {

            return $"\n=====Book======\n" +

                $"\nTitle => {Title}\nAuthor => {Author}\nPages => {Pages} pages\nPrice => {Price} $\n\n ";

        }

        public Book(string title, string author, int pages, double price)

        {

            Title = title;

            Author = author;

            Pages = pages;

            Price = price;

        }

        public void Print()

        {

            Console.Write(ToString());

        }


    }

    class Student : IPrintable

    {

        public string Name { get; set; }

        public int Age { get; set; }

        public int Group { get; set; }

        public int AverageScore { get; set; }

        public Student(string name, int age, int group, int averageScore)

        {

            Name = name;

            Age = age;

            Group = group;

            AverageScore = averageScore;

        }

        public override string ToString()

        {

            return $"\n=====Student {Name}=====\n" +

                $"\nAge => {Age}\nGroup => {Group}\nAverageScore => {AverageScore}\n\n";

        }


        public void Print()

        {

            Console.Write(ToString());

        }

    }

    class Invoice : IPrintable

    {

        public int Number { get; set; }

        public string CustomerName { get; set; } = string.Empty;

        public int Amount { get; set; }


        public bool IsPaid { get; set; } = false;

        public Invoice(int number, string customerName, int amount, bool isPaid)

        {

            Number = number;

            CustomerName = customerName;

            Amount = amount;

            IsPaid = isPaid;

        }


        public override string ToString()

        {

            var payment = IsPaid ? "[V]" : "[X]";


            return $"\nCustomer Name => {CustomerName}\nNumber => {Number} \nAmount => {Amount} $\nPayment status => {payment}";

        }


        public void Print()

        {

            Console.Write(ToString());


        }

    }

    #endregion









    #region 2


    interface ILogger
    {
        void Log(string message);
    }

    class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"[LOG] {DateTime.Now:HH:mm:ss} => {message}");
        }
    }

    class FileLogger : ILogger
    {
        readonly string _filePath;

        public FileLogger(string filePath = "log.txt")
        {
            _filePath = filePath;
        }

        public void Log(string message)
        {
            string logEntry = $"[LOG] {DateTime.Now:yyyy-MM-dd HH:mm:ss}: {message}";

            File.AppendAllText(_filePath, logEntry); 

        }
    }













    class CV
    {
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }
        public string Specialization { get; set; } = string.Empty;
        public List<string> Skills { get; set; } = new List<string>();

        public void Display()
        {
            Console.Write("\n" + new string('=', 40) + "\n");

            Console.Write("RESUME\n");
            
            Console.Write(new string('=', 40) + "\n");
            
            Console.Write($"Name: {Name}\n");
            
            Console.Write($"Age: {Age}\n");
            
            Console.Write($"Specialization: {Specialization}\n");
            
            Console.Write("Skills:");
            
            
            foreach (var skill in Skills)
            {
                Console.Write($"  • {skill}\n");
            }
            
            Console.Write(new string('=', 40) + "\n");
        }
    }

    class CVApplication
    {
        private readonly ILogger _logger;
        private CV _cv;

        public CVApplication(ILogger logger)
        {
            _logger = logger;
            _cv = new CV();
        }

        public void Run()
        {
            _logger.Log("CVApplication started\n");

            
            
                Console.Write("\n===== Create Resume =====\n");

                Console.Write("Enter your name => ");
                _cv.Name = Console.ReadLine();
                _logger.Log($"User entered name => {_cv.Name}\n");

                Console.Write("Enter your age => ");
                if (int.TryParse(Console.ReadLine(), out int age))
                {
                    _cv.Age = age;
                    _logger.Log($"User entered age => {age}\n");
                }

                else
                {
                    _logger.Log("Error : invalid age entered\n");
                    Console.Write("\nInvalid age!\n");
                    return;
                }

                Console.Write("Enter your specialization => ");
                _cv.Specialization = Console.ReadLine();
                _logger.Log($"User entered specialization: {_cv.Specialization}\n");

                Console.Write("Enter your skills (comma-separated) => ");
                string skillsInput = Console.ReadLine();
                _cv.Skills = skillsInput.Split(',', StringSplitOptions.RemoveEmptyEntries).Select(s => s.Trim()).ToList(); _logger.Log($"User entered skills: {skillsInput}");

                _logger.Log("Resume successfully created\n");
                Console.Write("\nResume successfully created!\n");

                _cv.Display();
                _logger.Log("Resume displayed on screen\n");
            
            
            
                
            

            _logger.Log("CVApplication finished\n");
        }
    }





    #endregion

















    public class Program

    {


        static void Main(string[] args)

        {


            #region test 1

            //List<IPrintable> a = new()

            //{

            //    new Book("Clean Code","Robert Martin", 464, 29.99),

            //    new Student("Yahya",18,123,100),

            //    new Invoice(233,"Yahya",2000, true)

            //};


            //foreach (var item in a)

            //{


            //    item.Print();

            //    Console.Write("\n\n");

            //}

            #endregion



            #region test 2

            ILogger logger = new FileLogger("log.txt");

            CVApplication cvApp = new CVApplication(logger);
            cvApp.Run();

            Console.Write("\nPress any key to exit...\n");
            Console.ReadKey();

            #endregion



        }

    }




}


