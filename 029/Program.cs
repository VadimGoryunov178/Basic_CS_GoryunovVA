// Подсчитать сумму цифр в числе

Console.WriteLine(Numbers(455)); // Программа



int Numbers(int N) // Подпрограмма
{
    int k=0;
    while(N>0)
    {
    k=k + N%10;
    N=N/10;
    }
    return k;
}