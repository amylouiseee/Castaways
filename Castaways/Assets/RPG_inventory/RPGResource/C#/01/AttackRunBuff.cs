using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackRunBuff : MonoBehaviour
{

    public GameObject EffectPre;

    void Start()
    {


    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Instantiate(EffectPre, other.transform.position - new Vector3(0, 0.1f, 0), Quaternion.identity);
            Player.speed += 2;
            Destroy(gameObject);
        }
    }


}
