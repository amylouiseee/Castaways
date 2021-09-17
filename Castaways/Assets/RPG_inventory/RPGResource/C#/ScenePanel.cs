using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScenePanel : MonoBehaviour
{


    public Button Button_Play;                          
    public Button Button_Next;                         
    public Button Button_Pre;                           
    public Button Button_Over;                          

    public static int Level_n = 1;                      
    public GameObject[] Level_img = new GameObject[3];   

    public GameObject[] Level_img02 = new GameObject[3];   
    public GameObject[] Level_img03 = new GameObject[3];   

    public static int CoinNum = 10;

    void Start()
    {
        Button_Play.onClick.AddListener(Button_PlayClickListener);           
        Button_Next.onClick.AddListener(Button_NextClickListener);           
        Button_Pre.onClick.AddListener(Button_PreClickListener);            

        Button_Over.onClick.AddListener(Button_OverClickListener);            

        Level_img[Level_n - 1].SetActive(true);                               
        Level_img02[Level_n - 1].SetActive(true);                              
        Level_img03[Level_n - 1].SetActive(true);                             
    }

    void Button_PlayClickListener()
    {
        if (Level_n == 1)
        {
            SceneManager.LoadScene(3);
        }
        else if (Level_n == 2)
        {
            SceneManager.LoadScene(6);
        }
        else if (Level_n == 3)
        {
            SceneManager.LoadScene(9);
        }

       
    }


    void Button_NextClickListener()
    {
        if (Level_n < 3)
        {
            Level_n += 1;

            CloseLeven();

            Level_img[Level_n - 1].SetActive(true);
            Level_img02[Level_n - 1].SetActive(true);
            Level_img03[Level_n - 1].SetActive(true);
        }
        else
        {
            Level_n = 1;

            CloseLeven();

            Level_img[Level_n - 1].SetActive(true);
            Level_img02[Level_n - 1].SetActive(true);
            Level_img03[Level_n - 1].SetActive(true);
        }
    }

 
    void Button_PreClickListener()
    {
        if (Level_n == 1)
        {
            Level_n = 3;

            CloseLeven();

            Level_img[Level_n - 1].SetActive(true);
            Level_img02[Level_n - 1].SetActive(true);
            Level_img03[Level_n - 1].SetActive(true);
        }
        else
        {
            Level_n -= 1;

            CloseLeven();

            Level_img[Level_n - 1].SetActive(true);
            Level_img02[Level_n - 1].SetActive(true);
            Level_img03[Level_n - 1].SetActive(true);
        }
    }


    void CloseLeven()
    {
        for (int n=0;n< Level_img.Length; n++)
        {
            Level_img[n].SetActive(false);
            Level_img02[n].SetActive(false);
            Level_img03[n].SetActive(false);
        }
    }

    void Button_OverClickListener()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
      Application.Quit();
#endif
    }
}
