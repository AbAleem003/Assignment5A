using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ROTATOR : MonoBehaviour
{
    public float X,Y,Z,SPEED;
    void Update()
    {
        gameObject.transform.Rotate(X*SPEED,Y* SPEED, Z* SPEED);
    }
}
