using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    public float speed = 1;

    void Start()
    {
        
    }

    void Update()
    {
        transform.position = (Vector2)transform.position + Vector2.left * speed * Time.deltaTime;
    }
}
