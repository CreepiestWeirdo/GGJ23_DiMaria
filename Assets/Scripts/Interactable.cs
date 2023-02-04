using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PopUpController))]
public class Interactable : MonoBehaviour
{
    public bool grabbable;
    
    private PopUpController popUpController;

    private void Awake()
    {
        popUpController= GetComponent<PopUpController>();
    }
    private void OnMouseDown()
    {
        if(grabbable)
        {
            Inventory.Instance.Add(gameObject);
        }
    }
}
