using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyLogic : MonoBehaviour
{
    int myNumber;

    void Awake()
    {
        
    }

    void Start()
    {
        myNumber = 5;
        print(myNumber);
    }

    void Update()
    {
        myNumber += 1;
    }

    void FixedUpdate()
    {
        
    }

    void LateUpdate()
    {
        print(myNumber);
    }
}
