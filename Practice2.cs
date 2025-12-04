using System;
using System.Reflection.Metadata;
namespace Program
{

#region First
     class Product
        {

            private string name;

            public string Name
            {
                get
                {
                    return name;
                }
                set
                {
                    name = value.Trim();
                }
            }


            private int price;

            public int Price
            {
                get { return price; }
                set
                {
                    if (value < 0)
                    {
                        throw new Exception("");
                    }

                    else
                    {
                        price = value;

                    }

                }
            }


            public string Category { get; set; }

            static int totalProducts;

            const string defaultCurrency = "AZN";

            readonly string productCode;



            string Help()
            {

                char[] a = { };

                string temp = totalProducts.ToString();

                for (int i = 0; i < 3; i++)
                {
                    a.Append(Category[i]);

                }


                for (int i = 0; i < temp.Length; i++)
                {
                    a.Append(temp[i]);

                }

                var v = a.ToString();

                return v;


            }

            public Product()
            {

                productCode = Help();
                totalProducts++;
            }





        }
     class Shop
    {

        private static Product[] products;

        public static int count;




    }

#endregion




#region Second


    class Car
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        readonly int vin;

        private static int nextVin;


        static Car()
        {
            nextVin = 1;
        }

        public Car()
        {
            vin = nextVin;
            nextVin++;
        }

        public static void ShowNextVin()
        {


            Console.Write(nextVin + "\n");

        }


        public int GetVin()
        {
            return vin;
        }

        public override string ToString()
        {
            return $"\n Car brand => {Brand}\n Car model => {Model}\n Car year => {Year} \n VIN => {GetVin()} \n";
        }


    }

    

    static class CarRegistry
    {
        private static Car[] car = new Car[1];

        private static int count = 0;
        

        

        static public void Register(Car othercar)
        {

            if (count == car.Length)
            {
                Car[] newCar = new Car[car.Length+1];
                Array.Copy(car, newCar, car.Length);
                car = newCar;
            }

            car[count] = othercar;
            
            count++;

        }



        static public void PrintAll()
        {


            for (int i = 0; i < car.Length; i++)
            {
                if (car[i] == null)
                    throw new Exception();

                Console.Write(car[i].ToString()); 


            }

        }



    }













    #endregion






#region Third


    class Student
    {
        public string FullName { get; set; }
        public string Group { get; set; }

        private int age;

        public int Age
        {
            get { return age; }
            set
            {
                if (value < 16 || value > 100)
                {
                    throw new Exception();
                }

                age = value; 
            }
        }

        readonly double registrationId;

        static public int count;


        public Student()
        {

            count++;

            registrationId = Math.Pow(count,2);

        }


        public override string ToString()
        {
            return $"\n Full Name of Student => {FullName} \n Group => {Group} \n Age of Student => {Age} \n Registration ID => {registrationId }\n\n";
        }




    }



    class Academy
    {

        public string Name { get; init; }

        Student[] students = new Student[1];

        private static int count;


        public void AddStudent(Student student)
        {
            if (count == students.Length)
            {
                Student[] newstudent = new Student[students.Length+1];

                Array.Copy(students, newstudent, students.Length);

                students = newstudent;


            }

            students[count] = student;
            count++;


        }


        public override string ToString()
        {
            return $"\n\n==================={Name}===================\n\n"
                +
                $" Count all of Students => {Student.count}\n\n";
        }


        public void PrintInfo()
        {
            this.ToString();

            for (int i = 0; i < students.Length; i++) 
            {
                if (students[i] == null)
                    throw new Exception();

                Console.WriteLine(students[i].ToString() + "\n");



            }



        }



    }







    #endregion


    class Program
    {
    
        
        static void Main()
        {


            #region Test CarRegistry
            //Car a = new Car()
            //{
            //    Brand = "Tesla",
            //    Model = "ModelX",
            //    Year = 2015

            //};

            //Car b = new Car()
            //{
            //    Brand = "Tesla",
            //    Model = "CyberTrack",
            //    Year = 2025

            //};



            //Car c = new Car()
            //{

            //    Brand = "Tesla",
            //    Model = "Model S Plaid",
            //    Year = 2024


            //};

            //CarRegistry.Register(a);
            //CarRegistry.Register(b);
            //CarRegistry.Register(c);

            //CarRegistry.PrintAll();
            #endregion


            Student d = new Student()
            {
                FullName = "Yahya Mamadli",
                Age = 18,
                Group = "FSDE_1_25_3_ru"

            };

            Student e = new Student()
            {
                FullName = "Farhad Rustamov",
                Age = 35,
                Group = "FSDE_1_25_3_ru"

            };

            Student f = new Student()
            {
                FullName = "Kamran Aslanov",
                Age = 25,
                Group = "FSDE_1_25_3_ru"

            };


            Academy academy = new Academy()
            {
                Name = "Step IT Academy"
            };

            academy.AddStudent(d);
            academy.AddStudent(e);
            academy.AddStudent(f);


            academy.PrintInfo();

            Console.Write("\n\n" + Student.count + "\n\n");

            











        }
    }
}
