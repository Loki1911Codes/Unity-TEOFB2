using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.Antlr3.Runtime.Collections;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{

    [SerializeField]
    private List<string> inventory = new List<string>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addItem(string item)
    {
        if (inventory.Count < 16)
        {
            inventory.Add(item);
            Debug.Log("Item at index" + inventory[0]);
            //You collected x
            Debug.Log("You collected: " + item);
        }else
        {
            //Inventory full.text
            Debug.Log("Full");
        }
    }

}
