using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
[AddComponentMenu("Game/GameManager")]
public class GameManager : MonoBehaviour
{

    public static GameManager Instance = null;
    
    //public int m_score = 0;

    public Text txt_score;

    public Player m_player;
    public Text Text_num_01;
    public Text Text_num_02;
    public Text Text_num_03;
    public Text Text_num_04;
    public Text Text_num_05;

    public  int num_01 = 0;
    public  int num_02 = 0;
    public  int num_03 = 0;
    public  int num_04 = 0;
    public  int num_05 = 0;

    // Use this for initialization
    void Start()
    {
        Instance = this;
        txt_score.text = ScenePanel.CoinNum.ToString();

        Text_num_01.text = num_01.ToString();
        Text_num_02.text = num_02.ToString();
        Text_num_03.text = num_03.ToString();
        Text_num_04.text = num_04.ToString();
        Text_num_05.text = num_05.ToString();
    }

    void Update()
    {  
      //  if (Input.GetKeyUp(KeyCode.Alpha1))
       // {
       //     if (num_01 > 0)
        //    {
        //        num_01--;//
         //       Text_num_01.text = num_01.ToString();//

       //         m_player.AddHp();
        //    }
       // }
    }

    public void SetScore(int score)
    {
        ScenePanel.CoinNum += score;

        txt_score.text = ScenePanel.CoinNum.ToString();

    }


    public void Add_01()
    {
        num_01++;
        Text_num_01.text = num_01.ToString();
    }

    public void Add_02()
    {
        num_02++;
        Text_num_02.text = num_02.ToString();
    }

    public void Add_03()
    {
        num_03++;
        Text_num_03.text = num_03.ToString();
    }

    public void Add_04()
    {
        num_04++;
        Text_num_04.text = num_04.ToString();
    }

    public void Add_05()
    {
        num_05++;
        Text_num_05.text = num_05.ToString();
    }

    public void Win()
    {
        if (num_02 == 1 && num_03 == 1 && num_04 == 1 && num_05 == 1)
        {
            SceneManager.LoadScene(4);
        }
        else
        {
            SceneManager.LoadScene(5);
        }
    }

}