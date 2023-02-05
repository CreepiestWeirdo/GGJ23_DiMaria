using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PopUpController : MonoBehaviour
{
    public Image dialogBoxImage;
    public float timeSpan = 2f;
    public string message;

    void Awake()
    {
        // se oculta el canvas al inicio
        dialogBoxImage.gameObject.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetMouseButton(1) && dialogBoxImage.isActiveAndEnabled)
        {
            StartCoroutine(Hide());
        }
    }

    private IEnumerator Hide()
    {
        yield return new WaitForSeconds(timeSpan);
        dialogBoxImage.gameObject.SetActive(false);
    }

    void OnMouseDown()
    {
        // mostramos el canvas y establecemos la descripcion
        dialogBoxImage.gameObject.SetActive(true);
        dialogBoxImage.GetComponentInChildren<TMP_Text>().text = message;
    }
}

// agregar script al GameObject que se desea que muestre el Pop-Up
// configurar componente UI Canvas y Text
// hay que agregar componente BoxCollider 2D al objeto y habilitar el trigger