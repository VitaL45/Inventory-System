using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public string itemName;
    public int quantity;
    public Sprite sprite;

    [TextArea]
    [SerializeField]
    public string itemDescription;
    private InventoryManager inventoryManager;

    // Start is called before the first frame update
    void Start()
    {
        inventoryManager = GameObject.Find("InventoryCanvas").GetComponent<InventoryManager>();
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            int leftOverItems = inventoryManager.AddItem(itemName, quantity, sprite, itemDescription);
            if (leftOverItems <= 0)
            {
                Destroy(gameObject);
            } 
            Destroy(gameObject);
        }
    }
}
