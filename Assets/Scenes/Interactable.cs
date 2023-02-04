using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    [SerializeField] string message;
    [SerializeField] TMP_Text dialogBox;
    private void OnMouseDown()
    {
        dialogBox.text = message;
    }
}
