int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());
double result = 1;

for(int i = 0; i < numberB; i++)
{
    result = result * numberA;
}
Console.WriteLine($"{numberA} -> {result}");

