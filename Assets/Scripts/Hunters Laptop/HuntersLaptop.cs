using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class HuntersLaptop : MonoBehaviour
{
    public string laptop = "Hunters Laptop";
    [SerializeField]
    public Rigidbody2D rb;
    public PlayerInventory pli;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
           
            pli.addItem("Hunters Laptop");
            Destroy(gameObject);

        }
    }
    // Start is called before the first frame update
    void Start()
    {
        pli = GameObject.FindGameObjectWithTag("Inventory").GetComponent<PlayerInventory>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
