using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyRotate : MonoBehaviour
{
    public Rigidbody2D rg2;

    void Start()
    {

    }

    void Update()
    {

    }

    void FixedUpdate()
    {
        rg2.linearVelocity = Vector2.left;
    }
}


