namespace Program
{

    class CV
    {
        public string name;

        public string lastname;

        public string city;

        public string profession;

        public string description;

        public int workExperience;



        public override string ToString()
        {


            return $" Name => {name}\n Lastname => {lastname}\n City of residence => {city}\n Profession => {profession}\n Description => {description}\n Work experience => {workExperience}\n" + $"\n Unfortunately, we are not interested in C# specialists, we work in C++, but we call you back!"; //😁)))))))
        }



    }





    class Program
    {
        static void Main()
        {


            CV p = new CV();

            Console.Write("Type your name => ");

            string name = Console.ReadLine();

            p.name = name;

            Console.Write("\n");


            Console.Write("Type your lastname => ");

            string lastname = Console.ReadLine();

            p.lastname = lastname;

            Console.Write("\n");


            Console.Write("Type your city of residence => ");

            string city = Console.ReadLine();

            p.city = city;

            Console.Write("\n");

            Console.Write("Type wich profession you prefer => ");

            string profession = Console.ReadLine();

            p.profession = profession;

            Console.Write("\n");

            Console.Write("Type anything about yourself => ");

            string description = Console.ReadLine();

            p.description = description;

            Console.Write("\n");

            Console.Write("Type your work expirience in years => ");
            
            string workExperience = Console.ReadLine();

            p.workExperience = Int32.Parse(workExperience);

            Console.Write("\n");

            Console.Write($"\n\n==============CV Constructor==============\n\n{p}");








        }
    }
}
