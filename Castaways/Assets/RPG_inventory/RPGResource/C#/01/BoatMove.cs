using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatMove : MonoBehaviour
{


    public GameObject Boat;

    public bool BoatMoveBool = false;
    public float speed = 1;

    public int Next = 0;
   
    public Vector3 Vec_Next02;

    public GameObject Player;
    public GameObject PlayerShop;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
         if (BoatMoveBool == true)
        {
            if (Next == 0)
            {
                float dis_r = Vector3.Distance(Boat.transform.position, Vec_Next02);

                if (dis_r >= 1)
                {
                    
                    Boat.transform.position = Vector3.MoveTowards(Boat.transform.position, Vec_Next02, speed * Time.deltaTime);
                }
                else
                {
                    Boat.transform.rotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);
                    BoatMoveBool = false;

                    PlayerShop.SetActive(false);
                    Player.SetActive(true);

                    Player.GetComponent<CharacterController>().enabled = false;
                    Player.transform.position = PlayerShop.transform.position;
                    Player.GetComponent<CharacterController>().enabled = true;

                    Next = 1;
                }
            }
       
        
        }    
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && Next == 0)
        {
            Player.SetActive(false);
            PlayerShop.SetActive(true);

           BoatMoveBool = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
 
    }


}
