using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NPC_dh02 : MonoBehaviour
{


    public Button TipBox_tiejiang_Button;        
    public Button TipBox_tiejiang_Button_NO;     
    public GameObject TipBox_Question;           
    public GameObject TipBox_tiejiang;           

    public AudioSource ClickSound;

    public GameObject GO_renwu;

    // Start is called before the first frame update
    void Start()
    {
        TipBox_tiejiang_Button.onClick.AddListener(TipBox_tiejiang_ButtonClickListener);
        TipBox_tiejiang_Button_NO.onClick.AddListener(TipBox_tiejiang_ButtonClickListener_NO);
    }

    // Update is called once per frame
    void Update()
    {
     
    }

    void TipBox_tiejiang_ButtonClickListener()
    {
        GO_renwu.SetActive(true);
        ClickSound.Play();
        TipBox_tiejiang.SetActive(false);  
        TipBox_Question.SetActive(true);
    }

    void TipBox_tiejiang_ButtonClickListener_NO()
    {
        ClickSound.Play();
        TipBox_tiejiang.SetActive(false);
        TipBox_Question.SetActive(true);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            TipBox_Question.SetActive(false);
            TipBox_tiejiang.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            TipBox_tiejiang.SetActive(false);
            TipBox_Question.SetActive(true);
        }
    }


}
