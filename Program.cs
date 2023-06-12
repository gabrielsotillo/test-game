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

public class Juego{

    public Jugador jugador, jugadorIA;
    public string elecJugador, elecIA;
  

    public Juego(){

        jugador = new Jugador("Jugador");
        jugadorIA = new Jugador("IA");


    }

    public void Iniciar(){

        Console.WriteLine("¡Comienza el juego!\n\n");

        while(true){
            Console.WriteLine("1.Piedra\n2.Papel\n3.Tijera\n\n");
            // Elige la opcion del Jugador y de la IA.
            elecJugador = jugador.Elegir();
            elecIA = jugadorIA.Elegir();
            Console.Clear();
            // Procesa y retorna el resultado mediante una string.
            Console.WriteLine(Procesar(elecJugador, elecIA)); 
            break;
        }

    }

    public string Procesar(string elecJugador, string elecIA){

        if (elecJugador == "Piedra"){

                if (elecIA == "Papel"){
                    return $"Has elegido {elecJugador} pero la IA eligio {elecIA}. Has perdido!";
                }
                else if (elecIA == "Tijera"){
                    return $"Has elegido {elecJugador} pero la IA eligio {elecIA}. Has ganado!";
                }
                else{
                    return $"Has elegido {elecJugador} pero la IA tambien eligio {elecIA}. Es un empate!";
                }
           
            }

        else if (elecJugador == "Papel"){

                if (elecIA == "Tijera"){
                    return $"Has elegido {elecJugador} pero la IA eligio {elecIA}. Has perdido!";
                }
                else if (elecIA == "Piedra"){
                    return $"Has elegido {elecJugador} pero la IA eligio {elecIA}. Has ganado!";
                }

                else{
                    return $"Has elegido {elecJugador} pero la IA tambien eligio {elecIA}. Es un empate!";
                }
            }

        else if (elecJugador == "Tijera"){

                if (elecIA == "Piedra"){
                    return $"Has elegido {elecJugador} pero la IA eligio {elecIA}. Has perdido!";
                }
                else if (elecIA == "Papel"){
                    return $"Has elegido {elecJugador} pero la IA eligio {elecIA}. Has ganado!";
                }

                else{
                    return $"Has elegido {elecJugador} pero la IA tambien eligio {elecIA}. Es un empate!";
                }
            }

        else {

            return "?";
        }

        
    }

}

public class Jugador{
    
    public string nombre;
    public string eleccion;
    public string[] opciones = {"Piedra", "Papel", "Tijera"};
    Random rnd = new Random();

    public Jugador(string nombreJugador){

        nombre = nombreJugador;

    }

    public string Elegir(){

        if (nombre == "Jugador"){

            eleccion = Console.ReadLine();

            switch (eleccion){

                case "1":
                    return opciones[0];

                case "2":
                    return opciones[1];

                case "3":
                    return opciones[2];
                
                default:
                    return "Eleccion no valida";

            }

        }
        else {

            // Aca va la eleccion aleatoria de la IA.
                
            return eleccion = opciones[rnd.Next(0,3)];
        }


    }

}