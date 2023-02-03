using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<string> items = new List<string>();

    public void AddItem(string item)
    {
        //agrega items
        items.Add(item);
        Debug.Log("Item Added: " + item);
    }

    public void RemoveItem(string item)
    {
        //remueve items
        items.Remove(item);
        Debug.Log("Item Removed: " + item);
    }

    public bool HasItem(string item)
    {
        //informa items
        return items.Contains(item);
    }
}