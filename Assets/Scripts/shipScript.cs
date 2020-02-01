using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipScript : MonoBehaviour
{

    //public float speed = 0.2f;
    //public float height = 0f;
    //public float depth = 0f;
    //private bool isZero = true;
    //private float lowSpeed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //Move ship to the right with both D and right key.
        /*if (Input.GetKey("right"))
        {
            transform.Translate(speed * Time.deltaTime, height, depth);
        }
        if (Input.GetKey("d"))
        {
            transform.Translate(speed * Time.deltaTime, height, depth);
        }*/

        //Move ship to left, both A and left key.
        /*if (Input.GetKey("left"))
        {
            transform.Translate(-speed * Time.deltaTime, height, depth);
        }
        if (Input.GetKey("a"))
        {
            transform.Translate(-speed * Time.deltaTime, height, depth);
        }

        if(!(transform.position.x == 0) && !Input.anyKey)
        {
            transform.Translate(-speed * Time.deltaTime, height, depth);
            if (transform.position.x < 0)
                transform.Translate(0, height, depth);
        }*/

    }
}
