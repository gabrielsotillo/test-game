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