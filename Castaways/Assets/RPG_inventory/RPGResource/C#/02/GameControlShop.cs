using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControlShop : MonoBehaviour {


    public Button Button_rw;
    public GameObject Player01;
    public GameObject Player02;
    public GameObject Player03;
    public GameObject UI_Chuang;
    public GameObject UI_renwu;
    public GameObject SpawnArea;

    // Use this for initialization
    void Start () {

        Button_rw.onClick.AddListener(Button_rwClickListener); 

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void Button_rwClickListener()
    {

        Player01.SetActive(false);
        Player02.SetActive(true);
        Player03.SetActive(false);
        UI_Chuang.SetActive(true);
        UI_renwu.SetActive(false);
        SpawnArea.SetActive(true);

    }


}
