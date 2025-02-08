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

    void OnEnable()
    {
        print("나타났다!");
    }

    void OnDisable()
    {
        print("사라졌다!");
    }

    void OnMouseDown()
    {
        print("오브젝트 클릭되었다!");
        rigid.AddForce (Vector2.up * 5, ForceMode2D.Impulse);
    }
}






