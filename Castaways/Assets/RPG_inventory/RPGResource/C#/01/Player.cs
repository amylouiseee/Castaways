using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour 
{

    public GameManager gameManager;

    public float rotspeed;
    public GameObject bolt;
    public AudioSource BoltSound;
    public Transform gun;

    public float firerate;
    private float nextfire;
    private float nextfire_ani = 0;
    private bool nextfire_of = false;
    public Animator animBoy;

    public int life = 100;
    public Slider HP_zj;
    public AudioSource HP_Sound;
    public GameObject FxPre;  
    public AudioSource hurtSound;

    public Text Text_PlayTime;
    public bool Run_Time = true;
    public float Time_Run = 600;

    public CharacterController PlayerMove;
    public float gravity = 10f;

    public static int RankNum = 1;
    public Text RankText;

    public static int experience = 0;
    public Text experienceText;

    public Text LifeText;

    public static int HurtNum = 25;
    public Text AttackPowerText;

    public static float speed = 3;
    public Text speedText;

    public Button CharacterAttributesButton;
    public GameObject CharacterAttributes;
    public Button CharacterAttributesReTurnButton;

    public GameObject RankBuffTx;

    public AudioSource GetAS;

    public AudioSource JBSound;

    void Start()
    {     
        RankText.text = RankNum.ToString();
     
        experience = 0;
        experienceText.text = experience.ToString();

        int life = 100;
        LifeText.text = life.ToString();

        HurtNum = 25;
        AttackPowerText.text = HurtNum.ToString();

        speed = 3;
        speedText.text = speed.ToString();

        CharacterAttributesButton.onClick.AddListener(CharacterAttributesListener);
        CharacterAttributesReTurnButton.onClick.AddListener(CharacterAttributesReTurnListener);
    }

    void Update()
    {
        if (life <= 0)
        {
            return;
        }

        if (Input.GetKey(KeyCode.J) && Time.time > nextfire)
        {
            BoltSound.Play();
            nextfire = Time.time + firerate;

            Instantiate(bolt, gun.position, gun.rotation);

            animBoy.SetBool("Attact02", true);

            nextfire_of = true;
        }

        if (nextfire_of == true)
        {
            nextfire_ani += Time.deltaTime;

            if (nextfire_ani > 0.5)
            {
                animBoy.SetBool("Attact02", false);
                nextfire_of = false;
                nextfire_ani = 0;
            }
        }

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
        if (Run_Time == true)
        {
            Time_Run -= Time.deltaTime;
            Text_PlayTime.text = string.Format("{0:0}", Time_Run);

            if (Time_Run <= 0)
            {
                Time_Run = 0;
                Text_PlayTime.text = string.Format("{0:0}", Time_Run);
              

                SceneManager.LoadScene(5);
            }
        }

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "JB")
        {
            GetAS.Play();
            gameManager.SetScore(1);
        }  

        if (other.tag == "HP")
        {
            GetAS.Play();
            Destroy(other.gameObject);

            gameManager.Add_01();
        }

        if (other.tag == "flower01")
        {
            Destroy(other.gameObject);
            gameManager.Add_02();
        }

        if (other.tag == "flower02")
        {
            Destroy(other.gameObject);
            gameManager.Add_03();
        }

        if (other.tag == "flower03")
        {
            Destroy(other.gameObject);
            gameManager.Add_04();
        }

        if (other.tag == "flower04")
        {
            Destroy(other.gameObject);
            gameManager.Add_05();
        }

        if (other.tag == " Dead")
        {
            SceneManager.LoadScene(5);
        }

        if (other.tag == "Win")
        {
            gameManager.Win();
        }
    }

    void OnTriggerExit(Collider other)
    {
    
    }

    public void OnDamage(int damage)
    {
    
        Vector3 decalPos = this.gameObject.transform.position - (Vector3.up * 0.05f);
        Quaternion decalRot = Quaternion.Euler(90, -2f, Random.Range(0, 360));
        GameObject blood2 = (GameObject)Instantiate(FxPre, decalPos, decalRot);
  
        Destroy(blood2, 2.0f);
        hurtSound.Play();

        life -= damage;
        HP_zj.value = life;

        if (life <= 0)
        {
            SceneManager.LoadScene(5);
        }
    }

    public void AddHp()
    {
       
        if (life > 80)
        {
            life = 100;
        }
        else
        {
            life += 20;
        }
        HP_Sound.Play();
        HP_zj.value = life;
    }

    void CharacterAttributesListener()
    {
        RankText.text = RankNum.ToString();
        experienceText.text = experience.ToString();
        LifeText.text = life.ToString();
        AttackPowerText.text = HurtNum.ToString();
        speedText.text = speed.ToString();

        CharacterAttributes.SetActive(true);

        Time.timeScale = 0;
    }

    void CharacterAttributesReTurnListener()
    {
        CharacterAttributes.SetActive(false);

        Time.timeScale = 1;
    }


    public void Addexperience()
    {  
       experience += 20;
        if (experience == 100)
        {
            Instantiate(RankBuffTx,this.transform.position - new Vector3(0, 0.1f, 0), Quaternion.identity);

            RankNum++;
            HurtNum += 10;
            experience = 0;
        }
    }


}
