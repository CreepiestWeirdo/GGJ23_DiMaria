using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public static Inventory _instance;

    public static List<GameObject> MyInventory { get; private set; } = new List<GameObject>();
    [SerializeField] TMP_Text dialogBox;
    [SerializeField] Image inventoryImage;

    private void Awake()
    {
        if (_instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public void Add(GameObject item)
    {
        MyInventory.Add(item);
        AddItemToInventoryImage(item.GetComponent<SpriteRenderer>());
    }

    private void AddItemToInventoryImage(SpriteRenderer sprite)
    {
        GameObject go = new();
        go.name = sprite.GetComponentInParent<Transform>().name;
        go.AddComponent<Image>();
        go.GetComponent<Image>().sprite = sprite.sprite;
        go.GetComponent<Image>().color = sprite.color;
        go.transform.SetParent(inventoryImage.transform);
    }

    public void Remove(GameObject item)
    {
        MyInventory.Remove(item);
    }

    public bool Contains(GameObject item)
    {
        return MyInventory.Contains(item);
    }
}
