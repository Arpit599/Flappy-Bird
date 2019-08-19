using UnityEngine;
using System.Collections;

public class RepeatingBackground : MonoBehaviour
{

    private BoxCollider2D groundCollider;        
    private float groundHorizontalLength;        

    //Awake is called before Start.
    private void Awake()
    {
        //Get and store a reference to the collider2D attached to Ground.
        groundCollider = GetComponent<BoxCollider2D>();
        //Store the size of the collider along the x axis (its length in units).
        groundHorizontalLength = groundCollider.size.x;
    }

    //Update runs once per frame
    private void Update()
    {
        //Check if the difference along the x axis between the main Camera and the position of the object this is attached to is greater than groundHorizontalLength.
        if (transform.position.x < -groundHorizontalLength)
        {
            //If true, this means this object is no longer visible and we can safely move it forward to be re-used.
            RepositionBackground();
        }
    }
    
    private void RepositionBackground()
    {
        
        Vector2 groundOffSet = new Vector2(groundHorizontalLength * 2f, 0);

        transform.position = (Vector2)transform.position + groundOffSet;
    }
}