using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSprite : MonoBehaviour
{
    SpriteRenderer spriter;

    void Start()
    {
        spriter = GetComponent<SpriteRenderer>();
    }

    public void SetSprite(Sprite sp)
    {
        spriter.sprite = sp;
    }
}
