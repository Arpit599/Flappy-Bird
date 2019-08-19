using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class bird : MonoBehaviour
{
    private float upforce=250f;
    private bool isDead=false;
    Rigidbody2D rb;
    private Animator anim;
    public GameObject deathnote;
  
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
  
    }


    void Update()
    {
        if(isDead==false)
        {
            if (Input.GetMouseButtonDown(0))
            {
                rb.velocity = Vector2.zero;
                rb.AddForce(new Vector2(0, upforce));
                anim.SetTrigger("Flap");
            }
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        isDead = true;
        rb.velocity = Vector2.zero;
        anim.SetTrigger("Die");
        GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>().BirdDied();
        deathnote.gameObject.SetActive(true);
    }
}
