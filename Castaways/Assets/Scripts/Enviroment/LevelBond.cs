using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBond : MonoBehaviour
{
    public static float leftSide = -6f;
    public static float rightSide = 6f;
    public float internalLeft;
    public float internalRight;


    void Update()
    {
        internalLeft = leftSide;
        internalRight = rightSide;
    }
}

