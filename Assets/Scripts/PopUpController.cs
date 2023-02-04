using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PopUpController : MonoBehaviour
{
    public TMP_Text dialogBox;
    public float timeSpan = 2f;
    public string message;

    void Awake()
    {
        // se oculta el canvas al inicio
        dialogBox.gameObject.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetMouseButton(1) && dialogBox.isActiveAndEnabled)
        {
            StartCoroutine(Hide());
        }
    }

    private IEnumerator Hide()
    {
        yield return new WaitForSeconds(timeSpan);
        dialogBox.gameObject.SetActive(false);
    }

    void OnMouseDown()
    {
        // mostramos el canvas y establecemos la descripcion
        dialogBox.gameObject.SetActive(true);
        dialogBox.text = message;
    }
}

// agregar script al GameObject que se desea que muestre el Pop-Up
// configurar componente UI Canvas y Text
// hay que agregar componente BoxCollider 2D al objeto y habilitar el trigger