using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerControlShop : MonoBehaviour {



    public float speed;
    public float rotspeed;
    private CharacterController PlayerMove;

    public int score = 0;     
    public Text score_text;   
    public AudioSource GetSound; 

    public Text TimeText;
    public float TimeNum = 120;

    // Use this for initialization
    void Start()
    {
        PlayerMove = gameObject.GetComponent<CharacterController>();  
    }

    // Update is called once per frame
    void Update()
    {
        if (TimeNum > 0)
        {
            TimeNum -= Time.deltaTime;
            TimeText.text = TimeNum.ToString("0");
        }
        else
        {
        
            SceneManager.LoadScene(8);
        }

        float x = 0, y = 0, z = 0;

    
        if (Input.GetKey(KeyCode.W))
        {
            y += speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            y -= speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.forward * Time.deltaTime * -rotspeed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.forward * Time.deltaTime * rotspeed);
        }

        PlayerMove.Move(transform.TransformDirection(new Vector3(x, y, z)));
    }


    void OnTriggerEnter(Collider other)
    {
       
  
        if (other.tag == "Transh")
        {
            Destroy(other.gameObject);

            score += 1;
            score_text.text = string.Format("{0:0}", score);
            GetSound.Play();
            if (score >= 10)
            {
          
                SceneManager.LoadScene(7);
            }
        }
    }
}
