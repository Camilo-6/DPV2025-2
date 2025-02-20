using UnityEngine;

public class obtenerPuntos : MonoBehaviour
{
    // Puntaje
    [SerializeField] private int puntaje = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        puntaje = 0;
        Debug.Log("Puntaje: " + puntaje);
    }

    public void OnTriggerEnter(Collider other)
    {
        // Si el objeto colisiona con un punto, lo destruye y obtiene 10 puntos
        if (other.gameObject.tag == "puntos")
        {
            Destroy(other.gameObject);
            // Ganar puntos
            puntaje += 10;
            Debug.Log("Ganaste 10 puntos, tu puntaje es: " + puntaje);
        }
    }
}
