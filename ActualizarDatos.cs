using UnityEngine;
using Firebase.Database;

public class ActualizarDatos : MonoBehaviour
{
    DatabaseReference referencia;

    void Start()
    {
        referencia = FirebaseDatabase.DefaultInstance.RootReference;

        ActualizarPuntos();
    }

    void ActualizarPuntos()
    {
        referencia.Child("Jugadores").Child("Raymundo").Child("puntos").SetValueAsync(3000);

        Debug.Log("Puntos actualizados");
    }
}
