using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelMenuScript : MonoBehaviour
{
    //variables for each button
    public bool levelOne;
    public bool levelTwo;
     
    //on mouse release
    void OnMouseUp()
    {
        if (levelOne) //load level 1
        {
            Application.LoadLevel(2);
        }
        if (levelTwo) // load level 2
        {
            Application.LoadLevel(3);
        }

    }
}
