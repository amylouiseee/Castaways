using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Shenzhipk : MonoBehaviour
{



    public Button ShenzhiButton;     
    public GameObject ShenzhiPanel;  
    
    public int Again_num = 6;     
    public Button GameAgainPlayButton; 
    public Button GameRePlayButton;    
    public Button GameLevelButton;     

    public Button GameQuitButton;     

    public Slider AudioSlider;
    public AudioSource SoundAudio;

    // Start is called before the first frame update
    void Start()
    {
        ShenzhiButton.onClick.AddListener(ShenzhiButtonClickListener);   

        GameAgainPlayButton.onClick.AddListener(GameAgainPlayButtonListener);   
        GameRePlayButton.onClick.AddListener(GameRePlayButtonClickListener);   
        GameQuitButton.onClick.AddListener(GameQuitButtonClickListener);       
        GameLevelButton.onClick.AddListener(GameLevelButtonLis);
    }

    // Update is called once per frame
    void Update()
    {
     
        SoundAudio.volume = AudioSlider.value;
    }

    void ShenzhiButtonClickListener()
    {
        ShenzhiPanel.SetActive(true);

        Time.timeScale = 0;
    }

    void GameAgainPlayButtonListener()
    {
        SceneManager.LoadScene(Again_num);
        Time.timeScale = 1;
    }

    void GameRePlayButtonClickListener()
    {
        ShenzhiPanel.SetActive(false);

        Time.timeScale = 1;
    }

    void GameQuitButtonClickListener()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
      Application.Quit();
#endif
    }

    void GameLevelButtonLis()
    {
        Time.timeScale = 1;

        SceneManager.LoadScene(2);
    }

}
