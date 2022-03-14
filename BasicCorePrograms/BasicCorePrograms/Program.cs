// See https://aka.ms/new-console-template for more information
Console.WriteLine(" Welcome to Harmonic Number  ");

Console.WriteLine("Enter the Harmonic you want to find\n");
int number = Convert.ToInt32(Console.ReadLine());
double result = 0;
for (double i = 1; i <= number; i++)
{
    result += 1 / i;
}

Console.WriteLine("The Value of Harmonic " + number + " :" + result + "\n");