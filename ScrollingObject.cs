using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingObject : MonoBehaviour
{
    Rigidbody2D rb;
    private float speed = 2.5f;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-speed, 0);
    }

   
    void Update()
    {
     if(GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>().gameover)
        {
            rb.velocity = Vector2.zero;
        }
    }
}
