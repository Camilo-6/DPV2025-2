using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class poder : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            StartCoroutine(superVelocidad(other.gameObject));
            // Destroy(this.gameObject, 3.0f);
        }
    }

    IEnumerator superVelocidad(GameObject player)
    {
        this.gameObject.GetComponent<MeshRenderer>().enabled = false;
        this.gameObject.GetComponent<Collider>().enabled = false;
        movimientoPersonaje mp = player.GetComponent<movimientoPersonaje>();
        mp.setVelocidad(5.0f);
        yield return new WaitForSeconds(3.0f);
        mp.resetVelocidad();
        Destroy(this.gameObject);
    }
}
