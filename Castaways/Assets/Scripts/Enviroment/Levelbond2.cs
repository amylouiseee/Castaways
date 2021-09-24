using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levelbond2 : MonoBehaviour
{
    public static float leftSide = -2f;
    public static float rightSide = 11f;
    public float internalLeft;
    public float internalRight;


    void Update()
    {
        internalLeft = leftSide;
        internalRight = rightSide;
    }
}
