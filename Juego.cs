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