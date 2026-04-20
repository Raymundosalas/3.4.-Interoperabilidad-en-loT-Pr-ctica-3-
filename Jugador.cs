[System.Serializable]
public class Jugador
{
    public string nombre;
    public int puntos;
    public int nivel;
    public int monedas;

    public Jugador(string nombreJugador, int puntosJugador, int nivelJugador, int monedasJugador)
    {
        nombre = nombreJugador;
        puntos = puntosJugador;
        nivel = nivelJugador;
        monedas = monedasJugador;
    }
}
