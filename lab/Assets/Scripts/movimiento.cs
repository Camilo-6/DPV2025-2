using UnityEngine;

public class movimiento : MonoBehaviour
{
    // Velocidad
    public float velocidad = 2.0f;
    // Movimiento vertical
    public float movimientoVertical;
    // Movimiento horizontal
    public float movimientoHorizontal;
    // Rigidbody
    public Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        movimientoHorizontal = Input.GetAxis("Horizontal");
        movimientoVertical = Input.GetAxis("Vertical");
        
        // Empujar el objeto la version vista en clase
        Vector3 movimiento = new Vector3(movimientoHorizontal, 0.0f, movimientoVertical);
        rb.AddForce(movimiento * velocidad);
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "enemigo")
        {
            Destroy(gameObject);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("Colision con " + other.gameObject.tag);
        if (other.gameObject.tag == "puntos")
        {
            Destroy(other.gameObject);
            // Ganar puntos
            Debug.Log("Ganaste 10 puntos");
        }
    }           
}
