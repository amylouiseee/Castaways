using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BackLevelMenu : MonoBehaviour
{

    public Button LevelMenuBtn;

    // Start is called before the first frame update
    void Start()
    {
        LevelMenuBtn.onClick.AddListener(LevelMenuBtnLis);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LevelMenuBtnLis()
    {
        SceneManager.LoadScene("LevelMenu");
    }


}
