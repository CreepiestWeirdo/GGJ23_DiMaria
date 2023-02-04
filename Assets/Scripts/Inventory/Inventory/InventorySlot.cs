using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySlot : MonoBehaviour
{
    public bool Available { get; private set; }

    private void Awake()
    {
        Available = true;
    }

    public void SetAvailable(bool value)
    {
        Available = value;
    }
}
