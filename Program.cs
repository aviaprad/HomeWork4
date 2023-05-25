// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
/*
void MetFindPower(int a, int b)
{
   int power = 1;
   for (int i = 1; i <= b; i++)
   {
    power *= a; // power = power * a
   }
   Console.WriteLine($"Power of number {a} in {b} is {power}");
}
Console.WriteLine("Input your number A: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input your number B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

MetFindPower(numberA, numberB);
*/


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

/*
int SumOfDigits (int number)  
{
    int sumDigits = 0;      
    while ( number >0)
    {                           
        sumDigits += number % 10;
        number /= 10;
    }
    return sumDigits;
}

Console.WriteLine("Input number: ");
int user_num = Convert.ToInt32(Console.ReadLine());
if (user_num <= 0)
{                               
    while (user_num <= 0)
    {
        Console.WriteLine("Enter POSITIVE number: ");
        user_num = Convert.ToInt32(Console.ReadLine());
    }
}

Console.WriteLine(SumOfDigits(user_num));

*/


// Задача 29: Напишите программу, которая задаёт массив из любого количества элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Write("Enter array size number: ");
 int size = Convert.ToInt32(Console.ReadLine());

int[] array = new int[size];

 for (int i = 0; i < size; i++)
   {
     array[i] = new Random().Next(size+1);
     Console.Write(array[i] + "; ");
   }
 Console.WriteLine();
 
