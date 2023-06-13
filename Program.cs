internal class Program
{
    private static void Main(string[] args)
    {
        string menuOption;
        
        // Menu principal de la aplicación.
        while(true){

            Console.WriteLine("1. Jugar\n2. Salir\n");
            menuOption = Console.ReadLine();
            Console.Clear();

            if (menuOption == "1"){
                Juego juego = new Juego();
                juego.Iniciar();
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



