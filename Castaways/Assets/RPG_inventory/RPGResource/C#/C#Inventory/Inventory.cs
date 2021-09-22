using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{

    public Text HealthStoneText;
    public static int HealthStoneNum = 0;
    public Button HealthStoneButton;

    public Player PlayerController_;
    public AudioSource GetHealthStone;

    public Text[] InventoryText;
    public static int InventoryNum02 = 0;
    public static int InventoryNum03 = 0;
    public static int InventoryNum04 = 0;
    public Button[] InventoryBtn;

    // Start is called before the first frame update
    void Start()
    {   
        HealthStoneText.text = HealthStoneNum.ToString();

        InventoryText[0].text = InventoryNum02.ToString();
        InventoryText[1].text = InventoryNum03.ToString();
        InventoryText[2].text = InventoryNum04.ToString();


        HealthStoneButton.onClick.AddListener(UsedHealthStone);

        InventoryBtn[0].onClick.AddListener(UsedAttack);
        InventoryBtn[1].onClick.AddListener(UsedRun);
        InventoryBtn[2].onClick.AddListener(UsedFunction);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            UsedHealthStone();
        }
    }

    public void UsedHealthStone()
    {
        if (HealthStoneNum > 0)
        {
            HealthStoneNum--;
            HealthStoneText.text = HealthStoneNum.ToString();
            GetHealthStone.Play();

            PlayerController_.AddHp();        
        }
    }

    public void UsedAttack()
    {
        if (InventoryNum02 > 0)
        {
            InventoryNum02--;
            InventoryText[0].text = InventoryNum02.ToString();
            GetHealthStone.Play();

            Player.HurtNum += 5;
        }
    }

    public void UsedRun()
    {
        if (InventoryNum03 > 0)
        {
            InventoryNum03--;
            InventoryText[1].text = InventoryNum03.ToString();
            GetHealthStone.Play();

            Player.speed += 2;
        }
    }

    public void UsedFunction()
    {
        if (InventoryNum04 > 0)
        {
            InventoryNum04--;
            InventoryText[2].text = InventoryNum04.ToString();
            GetHealthStone.Play();
          
            PlayerController_.AddHp();
        }
    }



}
