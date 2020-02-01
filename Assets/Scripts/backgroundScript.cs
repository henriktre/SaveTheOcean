using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundScript : MonoBehaviour
{

    public float backgroundSpeed = 0.2f;
    public float speed = 1f;
    private float lowSpeed = 0.15f;

    private MeshRenderer mesh_Renderer;
    // Start is called before the first frame update
    void Start()
    {
        mesh_Renderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Time.time * backgroundSpeed;

        Vector2 offset = new Vector2(x, 0);

        mesh_Renderer.sharedMaterial.SetTextureOffset("_MainTex", offset);

        /*if(backgroundSpeed < targetSpeed)
        {
            if (Input.GetKey("right") || Input.GetKey("d"))
            {
                backgroundSpeed += 0.2f;
            }
        }*/


        //Move ship to the right with both D and right key.
        if (Input.GetKey("right") || Input.GetKey("d"))
        {

            x = Time.time * speed;
            offset = new Vector2(x, 0);
            mesh_Renderer.sharedMaterial.SetTextureOffset("_MainTex", offset);

        }


        //Move ship to left, both A and left key.
        if (Input.GetKey("left") || Input.GetKey("a"))
        {
            /*if(backgroundSpeed > 0.2f)
            {
                backgroundSpeed -= 0.2f;
            }*/
            x = Time.time * lowSpeed;
            offset = new Vector2(x, 0);
            mesh_Renderer.sharedMaterial.SetTextureOffset("_MainTex", offset);
        }
        /*if (Input.GetKey("a"))
        {
            x = Time.time * lowSpeed;
            offset = new Vector2(x, 0);
            mesh_Renderer.sharedMaterial.SetTextureOffset("_MainTex", offset);
        }*/

    }

}
