using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeSpeedBuff : MonoBehaviour
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
            other.GetComponent<Player>().Time_Run += 120f;
            Destroy(gameObject);
        }
    }


}
