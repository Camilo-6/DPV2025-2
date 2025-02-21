using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class poderV : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        // Si el objeto colisiona con un jugador, se activa el poder
        if (other.gameObject.CompareTag("Player"))
        {
            StartCoroutine(superVelocidad(other.gameObject));
            // Destroy(this.gameObject, 3.0f);
        }
    }

    // Poder de super velocidad
    IEnumerator superVelocidad(GameObject player)
    {
        // Desactivar el objeto
        this.gameObject.GetComponent<MeshRenderer>().enabled = false;
        this.gameObject.GetComponent<Collider>().enabled = false;
        // Obtener el script de movimientoPersonaje
        movimientoPersonaje mp = player.GetComponent<movimientoPersonaje>();
        // Aumentar la velocidad del personaje
        mp.setVelocidad(5.0f);
        // Esperar 3 segundos
        yield return new WaitForSeconds(3.0f);
        Debug.Log("Poder desactivado");
        // Resetear la velocidad del personaje
        mp.resetVelocidad();
        // Destruir este objeto
        Destroy(this.gameObject);
    }
}
