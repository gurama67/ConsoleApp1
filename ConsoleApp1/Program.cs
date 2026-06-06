namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("შეიყვანეთ ასაკი: ");
            int age;
            int.TryParse(Console.ReadLine(), out age);

            if (age >= 18)
            {
                Console.WriteLine("გილოცავ! ხმის მიცემის უფლება გაქვთ.");
            }
            else
            {
                Console.WriteLine("სამწუხაროდ ხმის მიცემის უფლება ჯერ არ გაქვთ.");
            }

            Console.WriteLine();

            //davaleba2

            Console.Write("შეიყვანეთ პირველი რიცხვi: ");
            int num1;
            int.TryParse(Console.ReadLine(), out num1);

            Console.Write("შეიყვანეთ მე-2 რიცხვი: ");
            int num2;
            int.TryParse(Console.ReadLine(), out num2);

            Console.Write("შეიყვანეთ მე-3 რიცხვი: ");
            int num3;
            int.TryParse(Console.ReadLine(), out num3);

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("პირველი რიცხვი მაქსიმალურია წარმოდგენილ რიცხვებს შორის.");
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("მე-2 რიცხვი მაქსიმალურია წარმოდგენილ რიცხვებს შორის.");
            }
            else
            {
                Console.WriteLine("მე-3 რიცხვი მაქსიმალურია წარმოდგენილ რიცხვებს შორის.");
            }

            Console.WriteLine();

            //davaleba3

            Console.Write("შეიყვანეთ პირველი რიცხვი: ");
            int a;
            int.TryParse(Console.ReadLine(), out a);

            Console.Write("შეიყვანეთ მეორე რიცხვი: ");
            int b;
            int.TryParse(Console.ReadLine(), out b);

            int sum = a + b;

            if (a == b)
            {
                Console.WriteLine("შედეგი: " + (sum * 3));
            }
            else
            {
                Console.WriteLine("შედეგი: " + sum);
            }
        }
    }
}
