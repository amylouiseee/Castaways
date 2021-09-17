using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_JiNeng : MonoBehaviour {
 


    public float speed = 10;

    void Start () {
   
        GetComponent<Rigidbody>().velocity = transform.forward * speed;
  
        Destroy(gameObject, 0.2f);
    }
}
