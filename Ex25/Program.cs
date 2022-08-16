int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());
int result = 1;

for(int i = 0; i < numberB; i++)
{
    result = result * numberA;
}
Console.WriteLine($"{numberA} в степени {numberB} -> {result}");

