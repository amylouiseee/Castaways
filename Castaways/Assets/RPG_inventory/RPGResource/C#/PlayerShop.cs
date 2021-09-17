using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerShop : MonoBehaviour
{


    public float rotspeed = 110;

    public Animator animBoy;

    public CharacterController PlayerMove;
    public float gravity = 10f;

    public int speed = 5;

    public AudioSource JBSound;

    void Start()
    {
 
    }

    void Update()
    {
    
        float x = 0, y = 0, z = 0;

        y -= gravity * Time.deltaTime;

        if (Input.GetKey(KeyCode.W))
        {
            z += speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            z -= speed * Time.deltaTime;
        }
  
        if (Input.GetKey(KeyCode.A))
        {
            x = 1;
            transform.Rotate(Vector3.up * Time.deltaTime * -rotspeed);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            x = 1;
            transform.Rotate(Vector3.up * Time.deltaTime * rotspeed);
        }
  
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animBoy.SetTrigger("Jump");

            y += gravity * 30 * Time.deltaTime;
        }
        if (this.gameObject.transform.position.y >= 1.5)
        {
            y -= gravity * 10 * Time.deltaTime;
        }

        PlayerMove.Move(transform.TransformDirection(new Vector3(0, y, z)));


        if (z != 0 || x == 1)
        {
            if (!JBSound.isPlaying)
            {
                JBSound.Play();
            }

            animBoy.SetBool("Moving", true);
        }
        else
        {
            if (JBSound.isPlaying)
            {
                JBSound.Stop();
            }

            animBoy.SetBool("Moving", false);
        }
       

    }


}
