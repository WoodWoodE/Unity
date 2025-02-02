using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    Rigidbody2D rigid;
    Vector2 movement;

    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        movement = new Vector2(h, 0);
    }

    void FixedUpdate()
    {
        rigid.AddForce(movement);
    }
}






