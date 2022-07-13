// Определить количество цифр в числе. Сделать подпрограмму.
/* (Это метод просто программой)
int N=1234;
int k=0;
while(N!=0)
{
    // k=k+1
    k++;
    // N=N/10
    N/=10;
}
Console.WriteLine(k);
*/

// Метод с подпрограммой

Console.WriteLine(CountDigits(45)); // Программа




int CountDigits(int N) // Подпрограмма
{
    if (N==0) return 1;
    int k=0;
    while(N!=0)
    {
    k++;
    N/=10;
    }
    return k;
}
