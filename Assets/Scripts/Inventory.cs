using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public static Inventory Instance;
    public static List<GameObject> myInventory = new List<GameObject>();
    public GameObject myInventoryUI;

    private void Awake()
    {
        if(Instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance= this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public void Add(GameObject go)
    {
        myInventory.Add(go);
        AddObjectToInventoryUI(go);
    }

    private void AddObjectToInventoryUI(GameObject go)
    {
        GameObject newObject = new GameObject(go.name);
        newObject.AddComponent<Image>().sprite = go.GetComponent<SpriteRenderer>().sprite;
        newObject.GetComponent<Image>().color = go.GetComponent<SpriteRenderer>().color;
        newObject.transform.SetParent(myInventoryUI.transform);
    }
}