using UnityEngine;
using Firebase.Database;
using Firebase.Extensions;

public class LeerDatos : MonoBehaviour
{
    DatabaseReference referencia;

    void Start()
    {
        referencia = FirebaseDatabase.DefaultInstance.RootReference;

        ObtenerDatos();
    }

    void ObtenerDatos()
    {
        referencia.Child("Jugadores").Child("Raymundo").GetValueAsync().ContinueWithOnMainThread(task =>
        {
            if (task.IsCompleted)
            {
                DataSnapshot snapshot = task.Result;

                string nombre = snapshot.Child("nombre").Value.ToString();
                string puntos = snapshot.Child("puntos").Value.ToString();
                string nivel = snapshot.Child("nivel").Value.ToString();
                string monedas = snapshot.Child("monedas").Value.ToString();

                Debug.Log("Nombre: " + nombre);
                Debug.Log("Puntos: " + puntos);
                Debug.Log("Nivel: " + nivel);
                Debug.Log("Monedas: " + monedas);
            }
        });
    }
}
