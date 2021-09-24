using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuButtons : MonoBehaviour
{
    //variables for each button
    public bool playButton;
    public bool shopButton;
    public bool settingsButton;
    public bool exitButton;
     
    //on mouse release
    void OnMouseUp()
    {
        if (playButton) //play behaviour
        {
            Application.LoadLevel(1);
        }
        if (shopButton) // shop behaviour
        {
            //not implemented yet
        }
        if (settingsButton) // settings behaviour
        {
            //not implemented yet
        }
        if (exitButton) // exit behaviour
        {
            Application.Quit();
        }
    }

}
