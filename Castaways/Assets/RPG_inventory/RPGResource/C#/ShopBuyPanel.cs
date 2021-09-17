using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShopBuyPanel : MonoBehaviour
{

    public Button Button_Back;                           
    public Button Button_Over;                          

    public Text money_All_Text;                         
    public AudioSource shopAudio;     

    public Button Button_buy01;
    public static int money_buy01 = 5;
    public static int money_num01 = 0;
    public Text oney_num01_Text;

    public Button Button_buy02;
    public static int money_buy02 = 10;
    public static int money_num02 = 0;
    public Text oney_num02_Text;

    public Button Button_buy03;
    public static int money_buy03 = 15;
    public static int money_num03 = 0;
    public Text oney_num03_Text;

    public Button Button_buy04;
    public static int money_buy04 = 20;
    public static int money_num04 = 0;
    public Text oney_num04_Text;

   
    // Start is called before the first frame update
    void Start()
    {

        Button_Back.onClick.AddListener(Button_BackClickListener);            
        Button_Over.onClick.AddListener(Button_OverClickListener);            

        money_All_Text.text = ScenePanel.CoinNum.ToString();

        oney_num01_Text.text = money_num01.ToString();
        Button_buy01.onClick.AddListener(Button_buy01Listen);

        oney_num02_Text.text = money_num02.ToString();
        Button_buy02.onClick.AddListener(Button_buy02Listen);

        oney_num03_Text.text = money_num03.ToString();
        Button_buy03.onClick.AddListener(Button_buy03Listen);

        oney_num04_Text.text = money_num04.ToString();
        Button_buy04.onClick.AddListener(Button_buy04Listen);
    
    }

    void Button_BackClickListener()
    {
        SceneManager.LoadScene(2);
    }

    void Button_OverClickListener()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
      Application.Quit();
#endif
    }

    void Button_buy01Listen()
    {
        
        if (money_buy01 <= ScenePanel.CoinNum)
        {
            ScenePanel.CoinNum -= money_buy01;
            money_All_Text.text = ScenePanel.CoinNum.ToString();
            money_num01++;
            oney_num01_Text.text = money_num01.ToString();
            shopAudio.Play();
        }
    }

    void Button_buy02Listen()
    {
       
        if (money_buy02 <= ScenePanel.CoinNum)
        {
            ScenePanel.CoinNum -= money_buy02;
            money_All_Text.text = ScenePanel.CoinNum.ToString();
            money_num02++;
            oney_num02_Text.text = money_num02.ToString();
            shopAudio.Play();
        }
    }

    void Button_buy03Listen()
    {
      
        if (money_buy03 <= ScenePanel.CoinNum)
        {
            ScenePanel.CoinNum -= money_buy03;
            money_All_Text.text = ScenePanel.CoinNum.ToString();
            money_num03++;
            oney_num03_Text.text = money_num03.ToString();
            shopAudio.Play();
        }
    }

    void Button_buy04Listen()
    {
       
        if (money_buy04 <= ScenePanel.CoinNum)
        {
            ScenePanel.CoinNum -= money_buy04;
            money_All_Text.text = ScenePanel.CoinNum.ToString();
            money_num04++;
            oney_num04_Text.text = money_num04.ToString();
            shopAudio.Play();
        }
    }   

}
