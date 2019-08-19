using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class column : MonoBehaviour
{
    
   

    void Start()
    {
     
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>().Score();
        }
    }

}
