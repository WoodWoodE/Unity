using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slide : MonoBehaviour
{
    void Update()
    {
        // Time.deltaTime = 1 프레임에 소비된 시간
        transform.Translate(Time.deltaTime, 0, 0);
    }
}
