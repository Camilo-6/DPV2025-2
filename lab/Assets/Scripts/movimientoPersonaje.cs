using UnityEngine;

public class movimientoPersonaje : MonoBehaviour
{
    // Velocidades
    [SerializeField] private float velocidad, velocidadOriginal;
    // Direccion
    [SerializeField] private Vector3 direccion;
    // Gravedad
    [SerializeField] private float gravedad;
    // Controlador de personaje
    [SerializeField] private CharacterController cc;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.cc = this.gameObject.GetComponent<CharacterController>();
        velocidad = velocidadOriginal = 3.0f;
    }

    // Update is called once per frame
    void Update()
    {
        // Vector de direccion
        direccion = Vector3.zero;
        direccion.y -= gravedad * Time.deltaTime;
        direccion.x = Input.GetAxisRaw("Horizontal") * velocidad;
        direccion.z = Input.GetAxisRaw("Vertical") * velocidad;

        // Rotar hacia la direccion
        this.transform.LookAt(this.transform.position + new Vector3(direccion.x, 0, direccion.z));

        //this.transform.position += direccion * Time.deltaTime;
        // Mover el personaje
        this.cc.Move(direccion * Time.deltaTime);
    }

    // Setter de la velocidad
    public void setVelocidad(float velocidad)
    {
        this.velocidad = velocidad;
    }

    // Resetear la velocidad
    public void resetVelocidad()
    {
        this.velocidad = this.velocidadOriginal;
    }
}
