// See https://aka.ms/new-console-template for more information
Console.WriteLine(" Welcome to Quotient And Remainder   ");

int dividend,
    divisor;
{
    Console.Write("Enter dividend:");
    dividend = Convert.ToInt32(Console.ReadLine());
}
{
    Console.Write("Enter divisor:");
    divisor = Convert.ToInt32(Console.ReadLine());
}

int quotient = dividend / divisor;
int remainder = dividend % divisor;


    Console.WriteLine("Dividend:{0} Divisor:{1}", dividend, divisor);
    
        Console.WriteLine("Quotient = " + quotient);
        
            Console.WriteLine("Remainder = " +  remainder);