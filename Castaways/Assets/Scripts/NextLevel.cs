using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevel : MonoBehaviour
{
    void OnCollisionEnter()
    {
        Application.LoadLevel(1);
    }
}
