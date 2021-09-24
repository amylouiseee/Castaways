using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseHoverText : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Renderer>().material.color = Color.white; //initial color
    }

    void OnMouseEnter()
    {
        GetComponent<Renderer>().material.color = Color.blue; //on hover
    }

    void OnMouseExit()
    {
        GetComponent<Renderer>().material.color = Color.white; //reset after hover ends
    }
}
