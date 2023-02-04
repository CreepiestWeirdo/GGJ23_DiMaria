using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PopUpController : MonoBehaviour
{
    public Canvas popUpCanvas;
    public TMP_Text descriptionText;
    public float timeSpan = 0f;
    public string message;

    void Start()
    {
        // se oculta el canvas al inicio
        popUpCanvas.gameObject.SetActive(false);
    }

    private void Update()
    {
        if(Input.GetMouseButton(1) && popUpCanvas.isActiveAndEnabled)
        {
            StartCoroutine(Hide());
        }
    }

    private IEnumerator Hide()
    {
        yield return new WaitForSeconds(timeSpan);
        popUpCanvas.gameObject.SetActive(false);
    }

    void OnMouseDown()
    {
        // mostramos el canvas y establecemos la descripcion
        popUpCanvas.gameObject.SetActive(true);
        descriptionText.text = message;
    }
}

// agregar script al GameObject que se desea que muestre el Pop-Up
// configurar componente UI Canvas y Text
// hay que agregar componente BoxCollider 2D al objeto y habilitar el trigger