using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{

    public Button GameStartButton;

    void Start()
    {
        GameStartButton.onClick.AddListener(GameStartListener);           
    }

    void GameStartListener()
    {
        SceneManager.LoadScene(1);
    }

}
