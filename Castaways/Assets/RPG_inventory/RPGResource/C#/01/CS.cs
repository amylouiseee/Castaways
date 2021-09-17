using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CS : MonoBehaviour
{


    public Transform CS_;
    public GameObject Player_;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Player_.GetComponent<CharacterController>().enabled = false;
            other.gameObject.transform.localPosition = CS_.position;
            Player_.GetComponent<CharacterController>().enabled = true;
        }
    }

    private void OnTriggerStay(Collider other)
    {

        if (other.tag == "Player")
        {
            Player_.GetComponent<CharacterController>().enabled = false;
            other.gameObject.transform.localPosition = CS_.position;
            Player_.GetComponent<CharacterController>().enabled = true;
        }
    }

}
