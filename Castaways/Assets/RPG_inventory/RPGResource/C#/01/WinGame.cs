using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinGame : MonoBehaviour {


    public Button GameAgainButton;
    public Button GameLevelButton;
    public Button GameOverButton;

    public int LevelNum = 7;

    void Start()
    {
        ScenePanel.CoinNum += 20;

        GameAgainButton.onClick.AddListener(GameAgainButtonClickListener);     
        GameLevelButton.onClick.AddListener(GameLevelButtonClickListener); 
        GameOverButton.onClick.AddListener(GameOverClickListener);             
    }

    void GameAgainButtonClickListener()
    {
    
        Player.RankNum = 1;
        Player.experience = 0;
        Player.HurtNum = 25;
        Player.speed = 3;

        SceneManager.LoadScene(LevelNum);
    }

    void GameLevelButtonClickListener()
    {
   
        Player.RankNum = 1;
        Player.experience = 0;
        Player.HurtNum = 25;
        Player.speed = 3;

        SceneManager.LoadScene(2);
    }

    void GameOverClickListener()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
      Application.Quit();
#endif
    }

}
