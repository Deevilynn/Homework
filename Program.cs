// Задача 64: Написать рекурсивную функцию перевода из десятичной системы исчисления в двоичную.

// void MethodRecursion (int a)
// {
//    int devidend= a/2;
//    int remains = a % 2;

// if (devidend > 1){
//     a = devidend;
//     MethodRecursion(a); 
// }
// else {
//     Console.Write ("1");
// }
// Console.Write (remains);
// }
// Console.WriteLine("Enter your number: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Your result: ");
// MethodRecursion(a); 


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int Progression (int m, int n)
{
int results = 0;
int min;
int max;

if (m < 1 && n < 1) 
{
    return results;
}

else 

{ if (m > n) 
{
max = m;
min = n;
}
else {
max = n;
min = m;
}

if (max > 0 && min < 0 ){
min = 1;
}

for (int i = 0; i < (max - min + 1); i++) 
{
results = results + (min + i);
}
}

return results;
}

Console.WriteLine("Введите число M");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N");
int n= Convert.ToInt32(Console.ReadLine());

int result = Progression(m,n);
Console.WriteLine("Сумма натуральных элементов в промежутке между первым и вторым числом  = " + result);
