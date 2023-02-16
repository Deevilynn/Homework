// Задача 64: Написать рекурсивную функцию перевода из десятичной системы исчисления в двоичную.

void MethodRecursion (int a)
{
   int devidend= a/2;
   int remains = a % 2;

if (devidend > 1){
    a = devidend;
    MethodRecursion(a); 
}
else {
    Console.Write ("1");
}
Console.Write (remains);
}
Console.WriteLine("Enter your number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Your result: ");
MethodRecursion(a); 


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
