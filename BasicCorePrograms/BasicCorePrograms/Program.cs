// See https://aka.ms/new-console-template for more information
Console.WriteLine(" Welcome to Swap To Numbers   ");

{
    int number_One,
    number_Two,
    temp;

    Console.Write("\nEnter the First Number : ");
    number_One = Convert.ToInt32(Console.ReadLine());

    Console.Write("\nEnter the Second Number : ");
    number_Two = Convert.ToInt32(Console.ReadLine());

    temp = number_One;
    number_One = number_Two;
    number_Two = temp;
    Console.Write("\nAfter Swapping : ");
    Console.Write("\nFirst Number : " + number_One);
    Console.Write("\nSecond Number : " + number_Two);
    Console.ReadLine();
}