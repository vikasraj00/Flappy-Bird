using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundLoop : MonoBehaviour
{
    BoxCollider2D box;
    float totalLength;

    void Start()
    {
        box = GetComponent<BoxCollider2D>();
        totalLength = box.size.x;
    }

    void Update()
    {
        if (transform.position.x <= -totalLength)
        {
            transform.position = (Vector2)transform.position + Vector2.right * totalLength * 2f;
        }
        
    }
}
