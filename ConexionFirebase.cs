using UnityEngine;
using Firebase;
using Firebase.Database;
using Firebase.Extensions;

public class ConexionFirebase : MonoBehaviour
{
    DatabaseReference referencia;

    void Start()
    {
        FirebaseApp.CheckAndFixDependenciesAsync().ContinueWithOnMainThread(task =>
        {
            if (task.Result == DependencyStatus.Available)
            {
                Debug.Log("Firebase conectado correctamente");

                referencia = FirebaseDatabase.DefaultInstance.RootReference;

                GuardarDatos("Raymundo", 1500, 3, 250);
            }
            else
            {
                Debug.LogError("No se pudo conectar Firebase");
            }
        });
    }

    public void GuardarDatos(string nombre, int puntos, int nivel, int monedas)
    {
        Jugador jugador = new Jugador(nombre, puntos, nivel, monedas);

        string json = JsonUtility.ToJson(jugador);

        referencia.Child("Jugadores").Child(nombre).SetRawJsonValueAsync(json);

        Debug.Log("Datos enviados correctamente");
    }
}
