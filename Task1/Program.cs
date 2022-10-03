// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите число один");
int numberOne = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число два");
int numberTwo = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число три");
int numberThree = int.Parse(Console.ReadLine());

if (numberOne > numberTwo && numberOne>numberThree) 
{
    Console.WriteLine(numberOne + " MAX");
}
if (numberTwo > numberOne && numberTwo>numberThree) 
{
    Console.WriteLine(numberTwo + " MAX");
}
if (numberThree > numberOne && numberThree>numberTwo) 
{
    Console.WriteLine(numberOne + " MAX");
}