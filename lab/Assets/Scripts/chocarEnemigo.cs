using UnityEngine;

public class chocarEnemigo : MonoBehaviour
{
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "enemigo")
        {
            Destroy(gameObject);
        }
    }
}
