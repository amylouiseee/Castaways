using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashRotateShop : MonoBehaviour {



	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        gameObject.transform.Rotate(new Vector3(0, Random.Range(1, 5), 0));
    }


}
