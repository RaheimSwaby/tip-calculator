namespace practice_app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("would you like to tip today? yes tip or no tip?");
            string choice = Console.ReadLine();
            if(choice == "no tip") 
            {
                Console.WriteLine("why no tip?");
                Console.WriteLine("you should tip...");
               
            }

            Console.WriteLine("Enter your bill total");
            decimal billTotal = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("write your tip percentage");
            decimal tippercentage = Convert.ToDecimal(Console.ReadLine()) / 100;

            decimal tipamount = billTotal * tippercentage;  
            decimal grandtotal = billTotal + tipamount;

            Console.WriteLine("+++++++ tip calculator +++++++");
            Console.WriteLine($"Bill total: {billTotal}");
            Console.WriteLine($"tip percentage: {tippercentage}%");
            Console.WriteLine($"Tip amount:{tipamount}");
            Console.WriteLine($"grand total is {grandtotal}");

        }
    }
}
