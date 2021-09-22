using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class knapsackShop : MonoBehaviour
{

    public GameObject[] Boat;

    public Button[] BoatBtn;

    public GameObject[] BoatUi;


    // Start is called before the first frame update
    void Start()
    {
        BoatBtn[0].onClick.AddListener(UsedBaot01);
        BoatBtn[1].onClick.AddListener(UsedBaot02);
        BoatBtn[2].onClick.AddListener(UsedBaot03);
        BoatBtn[3].onClick.AddListener(UsedBaot04);

        if (ShopBuyPanel.money_num01 > 0)
        {
            BoatUi[0].SetActive(true);
        }
        if (ShopBuyPanel.money_num02 > 0)
        {
            BoatUi[1].SetActive(true);
        }
        if (ShopBuyPanel.money_num03 > 0)
        {
            BoatUi[2].SetActive(true);
        }
        if (ShopBuyPanel.money_num04 > 0)
        {
            BoatUi[3].SetActive(true);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UsedBaot01()
    {
        CleanBoat();
        Boat[1].SetActive(true);
    }
    public void UsedBaot02()
    {
        CleanBoat();
        Boat[2].SetActive(true);
    }
    public void UsedBaot03()
    {
        CleanBoat();
        Boat[3].SetActive(true);
    }
    public void UsedBaot04()
    {
        CleanBoat();
        Boat[4].SetActive(true);
    }

    public void CleanBoat()
    {

        for (int n = 0;n<5;n++)
        {
            Boat[n].SetActive(false);
        }

    }

}
