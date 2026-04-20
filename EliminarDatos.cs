using UnityEngine;
using Firebase.Database;

public class EliminarDatos : MonoBehaviour
{
    DatabaseReference referencia;

    void Start()
    {
        referencia = FirebaseDatabase.DefaultInstance.RootReference;

        EliminarJugador();
    }

    void EliminarJugador()
    {
        referencia.Child("Jugadores").Child("Raymundo").RemoveValueAsync();

        Debug.Log("Jugador eliminado");
    }
}
