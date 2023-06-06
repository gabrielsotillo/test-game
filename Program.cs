internal class Program
{
    private static void Main(string[] args)
    {
        string menuOption;
        
        while(true){

            Console.WriteLine("1. Jugar\n2. Salir");
            menuOption = Console.ReadLine();
            Console.Clear();
            if (menuOption == "1"){
                break;
            }
            else if(menuOption == "2"){
                Environment.Exit(0);
            }
            else{
                continue;
            }
        }

        


    }
}

class Jugador{
    
}