using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestCollider : MonoBehaviour
{

    public GameManager gameManager;
    public AudioSource GetSound;

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
            GetSound.Play();
            gameManager.SetScore(1);
        
            Destroy(this.gameObject);
        }
    }

}
