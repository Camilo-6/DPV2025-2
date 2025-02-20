using UnityEngine;

public class chocarEnemigo : MonoBehaviour
{
    // Inmunidad
    [SerializeField] private bool inmunidad = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        inmunidad = false;
    }

    public void OnCollisionEnter(Collision collision)
    {
        // Si el objeto colisiona con un enemigo
        if (collision.gameObject.tag == "enemigo")
        {
            if (!inmunidad)
            {
                // Si no tiene inmunidad, se destruye este objeto
                Destroy(gameObject);
            }
            else
            {
                // Si tiene inmunidad, se destruye el enemigo
                Destroy(collision.gameObject);
            }
        }
    }

    // Setter de la inmunidad
    public void setInmunidad(bool inmunidad)
    {
        this.inmunidad = inmunidad;
    }
}
