// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to Coin Flip!");

double head = 0, tail = 0;
Console.WriteLine("Enter the number of the coin is tossed");
int repeat = Convert.ToInt32(Console.ReadLine());
Random random = new Random();
for (int i = 0; i < repeat; i++)
{

    double rand = random.NextDouble();
    Console.WriteLine(rand + " ");
    if (rand < 0.5) tail++;
    else head++;

}
double headpercentage = (head / repeat) * 100;
Console.WriteLine("Percentage of getting head is :" + headpercentage + "\n");  // \n is prints new line.
Console.WriteLine("Percentage of getting tail is :" + (100 - headpercentage) + "\n");
Console.ReadLine();