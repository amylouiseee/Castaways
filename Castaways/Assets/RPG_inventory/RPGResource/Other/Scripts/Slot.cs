using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{

    public GameObject item;
    public string type;
    public int ID;
    public string description;
    public bool empty;

    public Transform slotIconGO;
    public Sprite icon;

    //publich void OnPointerClick(PointerEventData pointerEventData)
    //{
    //    UseItem();
    //}

    private void Start()
    {
        slotIconGO = transform.GetChild(0);
    }

    public void UpdateSlot()
    {
        slotIconGO.GetComponent<Image>().sprite = icon;
    }

   // public void UseItem()
    //{
        //dsadd
   // }
}
