using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BusinessmanCollider : MonoBehaviour
{

    public GameObject ShopBuyPanel;
    public bool IsOpen = false;

    public GameObject inventory;


    // Start is called before the first frame update
    void Start()
    {
        inventory.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            if (inventory.activeInHierarchy == false)
            {
                inventory.SetActive(true);
            }
            else
            {
                inventory.SetActive(false);
            }
        }
           

        if (Input.GetKey(KeyCode.O) && IsOpen == true)
        {
            ShopBuyPanel.SetActive(true);
        }
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player")
        {
            IsOpen = true;

           // ShopBuyPanel.SetActive(true);
        }
    }

    void OnTriggerExit(Collider collider)
    {
        if (collider.tag == "Player")
        {
            IsOpen = false;
            ShopBuyPanel.SetActive(false);
        }
    }

}
