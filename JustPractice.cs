using System.Collections.Specialized;

using System.Runtime.Serialization.Formatters;

using System.Security.Cryptography.X509Certificates;

using System.Text;

namespace Program

{

    public class Student

    {

        string name;

        int[] grades;


        public Student()

        {

        }


        public Student(string name, int[] grades)

        {

            this.name = name;

            this.grades = grades;

        }

        public double GetAverage()

        {

            double all = 0;


            for (int i = 0; i < grades.Length; i++)

            {

                all += grades[i];

            }




            return (all / grades.Length);

        }

        public int GetMaxGrade()

        {

            int max = grades[0];

            for (int i = 1; i < grades.Length; i++)

            {

                if (max < grades[i])

                {

                    max = grades[i];

                }


            }


            return max;

        }



        public override string ToString()

        {





            StringBuilder sb = new StringBuilder();

            sb.Append($"\n Student =>  {name}\n Grades => ");


            for (int i = 0; i < grades.Length; i++)
            {
                sb.Append(grades[i]);
                if (i < grades.Length - 1)
                {
                    sb.Append(", ");
                }
            }

            sb.Append($"\n Average grade => {GetAverage()} \n Max grade => {GetMaxGrade()}");

            return sb.ToString();
        }

        public void PrintInfo()
        {
            Console.WriteLine(ToString());
        }

    }









    public class Program
    {

        static double Avg(string num)
        {

            string[] num2 = num.Split(' ');

            double[] num3 = new double[num2.Length];




            for (int i = 0; i < num2.Length; i++)
            {

                if (Double.TryParse(num2[i], out double number))
                {
                    num3[i] = number;
                }

                else
                {
                    return -1;
                }
            }

            double sum = 0;

            for (int i = 0; i < num3.Length; i++)
            {
                sum += num3[i];

            }


            return (sum /num3.Length);


        }

        





    #region Trash1

        static string IntegerToString(int[] arr)
        {
            if (arr == null || arr.Length == 0)
                return string.Empty;

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < arr.Length; i++)
            {
                sb.Append(arr[i]); 

                if (i < arr.Length - 1) 
                {
                    sb.Append('-'); 
                }
            }

            return sb.ToString();
        }
        
        


        
        static int[] StringToInteger(string str)
        {




            if (string.IsNullOrEmpty(str))
                return new int[0]; 

            
            string[] parts = str.Split('-');

            
            int[] result = new int[parts.Length];


            for (int i = 0; i < parts.Length; i++)
            {
                
                if (int.TryParse(parts[i], out int number))
                {
                    result[i] = number;
                }



                else
                {
                    result[i] = 0;

                    
                }

            
            }





            return result;
        
        
        }




        static bool IsPalindrome(string s)
        {
            

            int left = 0;

            int right = s.Length - 1;

            while (left < right)
            {
                if (char.ToLower(s[left]) != char.ToLower(s[right]))
                    return false;

                left++;
                right--;
            }

            return true;
        }
        


        
        static int[] FindMaxInEachRowMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            
            int cols = matrix.GetLength(1);

            int[] maxValues = new int[rows]; 

            for (int i = 0; i < rows; i++)
            {
                int max = matrix[i, 0]; 


                for (int j = 1; j < cols; j++)
                {
                    if (matrix[i, j] > max)
                    {
                        max = matrix[i, j];
                    }
                }


                maxValues[i] = max;
            }

            return maxValues;
        }



        static int MatrixMajor(int[,] mtrx)
        {
            int summ = 0;

            //int rows = mtrx.GetLength(0);
            //int cols = mtrx.GetLength(1); 

            //int minDimension = Math.Min(rows, cols); 

            for (int i = 0; i < 3; i++)
            {
                summ += mtrx[i,i];

            }



            return summ;
        
        }

        
        
        static string Reverse(string s)
        {
            StringBuilder sb = new StringBuilder(s.Length);

            for (int i = s.Length - 1; i > -1; i--)
            {
                sb.Append(s[i]);
            }



            return sb.ToString();

        }



        static int[] EvenElements(int[] arr)

        {

            int count = 0;


            for (int i = 0; i < arr.Length; i++)

            {

                if (arr[i] % 2 == 0)

                {

                    count++;



                }



            }

            int[] a = new int[count];

            int index = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    a[index] = arr[i];
                    index++;
                }
            }

            return a;

        }



        static void MoveArray(ref int[] arr)
        {
            if (arr.Length == 0) return;

            int temp = arr[arr.Length - 1];


            for (int i = arr.Length - 1; i > 0; i--)
            {
                arr[i] = arr[i - 1];
            }


            arr[0] = temp;



        }



    #endregion

        static void Main()
        {



        #region Trash

            int[] numbers = { 5, 5, 5, 5, 6 };

            Student student = new Student("Elon", numbers);

            //student.PrintInfo();



            //int[] evenNumbers = EvenElements(numbers);


            //for (int i = 0; i < evenNumbers.Length; i++)
            //{
            //    Console.Write(evenNumbers[i] + " ");
            //}


            //Console.Write("\n");


            //MoveArray(ref numbers);


            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write(numbers[i] + " ");
            //}


            //string s = "Elon";

            //Console.Write(Reverse(s));



            int[,] mtrx = new int[3, 3]
            {
                {1,2,4},
                {1,2,6},
                {1,2,9},
            };




            int rows = mtrx.GetLength(0);
            int cols = mtrx.GetLength(1);
            int totalElements = rows * cols;

            

            //for (int i = 0; i < totalElements; i++)
            //{

            //    int row = i / cols;
            //    int col = i % cols;

            //    Console.Write($"mtrx[{row},{col}] = {mtrx[row, col]}\n");
            //}


            //Console.Write("\n\n\n");

            //int[] a = FindMaxInEachRowMatrix(mtrx);

            //for (int i = 0;i < a.Length; i++)
            //{
            //    Console.Write(a[i] +"\n"); 
            //}

            //string a = "AlLa";

            //var temp = IsPalindrome(a);

            //if (temp)
            //{
            //    Console.Write("V\n");


            //}

            //else
            //{
            //    Console.Write("X\n");
            //}





            //string num = "1-2-3-4-5-6t-6-7-8-9--10";


            //var v = StringToInteger(num);


            //for (int i = 0; i < v.Length; i++)
            //{

            //    Console.Write(v[i]+"\t");


            //}


            //var g = IntegerToString(numbers);

            //Console.Write(IntegerToString(numbers) + "\n"); 


            #endregion




            Console.Write("Type numbers => ");
            
            string num1 = Console.ReadLine();


            Console.Write(Avg(num1));






        }


    }


}

