int number = Convert.ToInt32(Console.ReadLine());
int result = 0;

int GetSumOfDigits(int num)
{
    int count = 0;
    while(num % 10 > 0)
    {
        result = result + num % 10;
        num = num / 10; 
        count++;
    }
    return result;
}

Console.WriteLine($"Сумма цифр в числе {number}: {GetSumOfDigits(number)}");




