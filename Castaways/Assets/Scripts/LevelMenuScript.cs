using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
            //Application.LoadLevel(2);
            SceneManager.LoadScene("Level 1");
        }
        if (levelTwo) // load level 2
        {
            // Application.LoadLevel(3);
            SceneManager.LoadScene("Level 2");
        }

    }
}
