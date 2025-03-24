using UnityEngine;
using UnityEngine.SceneManagement;

public class managerCambioEscena : MonoBehaviour
{
    // Cambiar de escena
    public void iniciarJuego()
    {
        SceneManager.LoadScene(1);
    }
}