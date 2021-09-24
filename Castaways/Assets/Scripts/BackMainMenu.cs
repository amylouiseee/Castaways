using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BackMainMenu : MonoBehaviour
{

    public Button MainMenuBtn;

    // Start is called before the first frame update
    void Start()
    {
        MainMenuBtn.onClick.AddListener(MainMenuBtnLis);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void MainMenuBtnLis()
    {
        SceneManager.LoadScene("MainMenu");
    }


}
