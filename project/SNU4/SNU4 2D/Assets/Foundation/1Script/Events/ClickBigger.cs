using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickBigger : MonoBehaviour
{
    void OnMouseDown()
    {
        transform.localScale = transform.localScale * 1.5f;
    }
}
