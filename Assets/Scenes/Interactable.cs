using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    [SerializeField] string message;
    [SerializeField] TMP_Text dialogBox;
    [SerializeField] bool grabbable;

    private void OnMouseDown()
    {
        dialogBox.text = message;

        if(grabbable)
        {
            Inventory._instance.Add(gameObject);
            gameObject.SetActive(false);
        }
    }
}
