// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.Write("Введите первое число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число N: ");
int N = Convert.ToInt32(Console.ReadLine());
NaturalSum(M,N);

int NaturalSum(int M, int N)
{
    int Sum=M;
    if (M==N)
    {
        return 0;
    }
    else
    {
        M++;
        Sum=M+NaturalSum(M,N);
        return Sum;
    }
    
}
Console.Write(NaturalSum(M-1, N));

