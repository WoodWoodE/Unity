using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slide : MonoBehaviour
{
    void Update()
    {
        // Time.deltaTime = 1 �����ӿ� �Һ�� �ð�
        transform.Translate(Time.deltaTime, 0, 0);
    }
}
