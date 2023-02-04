using UnityEngine;
using UnityEngine.UI;

public class PopUpController : MonoBehaviour
{
    public Canvas popUpCanvas;
    public Text descriptionText;

    void Start()
    {
        // se oculta el canvas al inicio
        popUpCanvas.gameObject.SetActive(false);
    }

    void OnMouseDown()
    {
        // mostramos el canvas y establecemos la descripcion
        popUpCanvas.gameObject.SetActive(true);
        descriptionText.text = "Escribir texto a mostrar";
    }
}

// agregar script al GameObject que se desea que muestre el Pop-Up
// configurar componente UI Canvas y Text
// hay que agregar componente BoxCollider 2D al objeto y habilitar el trigger