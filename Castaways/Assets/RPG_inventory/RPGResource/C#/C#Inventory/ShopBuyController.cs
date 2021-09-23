using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShopBuyController : MonoBehaviour
{

    public Button Button_Back;                       
    public GameObject knapsack_;                     
                  
    public AudioSource shopAudio;      

    public Button Button_buy01;
    public static int money_buy01 = 1;
    public static int money_num01 = 99;
    public Text oney_num01_Text;

    public Button Button_buy021;
    public static int money_buy021 = 1;
    public static int money_num021 = 99;
    public Text oney_num021_Text;

    public Button Button_buy022;
    public static int money_buy022 = 2;
    public static int money_num022 = 99;
    public Text oney_num022_Text;

    public Button Button_buy023;
    public static int money_buy023 = 3;
    public static int money_num023 = 99;
    public Text oney_num023_Text;

    public Text txt_score;

    // Start is called before the first frame update
    void Start()
    {
        Button_Back.onClick.AddListener(Button_BackClickListener);            

        oney_num01_Text.text = money_num01.ToString();
        Button_buy01.onClick.AddListener(Button_buy01Listen);
        ///////
        oney_num021_Text.text = money_num021.ToString();
        Button_buy021.onClick.AddListener(Button_buy021Listen);

        oney_num022_Text.text = money_num022.ToString();
        Button_buy022.onClick.AddListener(Button_buy022Listen);

        oney_num023_Text.text = money_num023.ToString();
        Button_buy023.onClick.AddListener(Button_buy023Listen);
    }

    void Button_BackClickListener()
    {
       
        knapsack_.SetActive(false);
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
        if (money_buy01 <= ScenePanel.CoinNum && money_num01 > 0)
        {
            ScenePanel.CoinNum -= money_buy01;
            txt_score.text = ScenePanel.CoinNum.ToString();

            money_num01--;

            oney_num01_Text.text = money_num01.ToString();
            shopAudio.Play();

            Inventory.HealthStoneNum++;
        }
    }

    void Button_buy021Listen()
    {
        if (money_buy021 <= ScenePanel.CoinNum && money_num021 > 0)
        {
            ScenePanel.CoinNum -= money_buy021;
            txt_score.text = ScenePanel.CoinNum.ToString();

            money_num021--;

            oney_num021_Text.text = money_num021.ToString();
            shopAudio.Play();

            Inventory.InventoryNum02++;
        }
    }

    void Button_buy022Listen()
    {
        if (money_buy022 <= ScenePanel.CoinNum && money_num022 > 0)
        {
            ScenePanel.CoinNum -= money_buy022;
            txt_score.text = ScenePanel.CoinNum.ToString();

            money_num022--;
            oney_num022_Text.text = money_num022.ToString();
            shopAudio.Play();

            Inventory.InventoryNum03++;
        }
    }

    void Button_buy023Listen()
    {
        if (money_buy023 <= ScenePanel.CoinNum && money_num023 > 0)
        {
            ScenePanel.CoinNum -= money_buy023;
            txt_score.text = ScenePanel.CoinNum.ToString();

            money_num023--;
            oney_num023_Text.text = money_num023.ToString();
            shopAudio.Play();

            Inventory.InventoryNum04++;
        }
    }

}
