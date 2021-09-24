using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
            // Application.LoadLevel(1);
            SceneManager.LoadScene("LevelMenu");
        }
        if (shopButton) // shop behaviour
        {
            //not implemented yet
            SceneManager.LoadScene("01Start");
        }
        if (settingsButton) // settings behaviour
        {
            //not implemented yet
        }
        if (exitButton) // exit behaviour
        {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
      Application.Quit();
#endif
        }
    }

}
