using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchDestroy : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
