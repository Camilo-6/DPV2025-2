using UnityEngine;
using TMPro;

public class obtenerPuntos : MonoBehaviour
{
    // Puntaje
    [SerializeField] private int puntaje = 0;
    // Texto de puntaje
    [SerializeField] private TMP_Text textoPuntaje;

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
            // Actualizar texto de puntaje
            textoPuntaje.text = puntaje.ToString();
        }
    }
}
