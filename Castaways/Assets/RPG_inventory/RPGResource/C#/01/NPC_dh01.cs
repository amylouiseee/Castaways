using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NPC_dh01 : MonoBehaviour {


    public GameObject TipBox_Question;          
    public GameObject TipBox_tiejiang;        

    // Start is called before the first frame update
    void Start()
    {

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
