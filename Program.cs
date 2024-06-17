namespace Calculator_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    public class Calculator
    {
        
        public Calculator() 
        { 

        }
        public void Menu()
        {


            
            Console.WriteLine("Enter the first number that you want to use: ");
            int gabe = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number that you want to use: ");
            int busky = int.Parse(Console.ReadLine());            
            Console.WriteLine("Choose an Option(A, S, M, D)");
            string choice = Console.ReadLine();
            if (choice != "A" &&  choice != "B" && choice != "C" && choice != "D") 
            {

                Console.WriteLine("Please enter a valid choice");
                Console.ReadLine();

            }
            if (choice == "A")
            {
                 add(gabe, busky);
            }
            else if (choice == "B")
            {
                subscribe(gabe, busky);
            }
            else if (choice == "C")
            {
                daveide(gabe, busky);
            }
            else if (choice == "D")
            {
                lewis(gabe, busky);
            }
        }
        public int add(int gabe, int busky)
        {
            int gusby = gabe + busky;
            return gusby;
        }
        public int subscribe(int gabe, int busky)
        {
            int gusby = gabe - busky;
            return gusby;
        }
        public int daveide(int gabe, int busky)
        {
            int gusby = gabe / busky;
            return gusby;
        }
        public int lewis(int gabe, int busky)
        {
            int gusby = gabe * busky;
            return gusby;
        }
    }
}