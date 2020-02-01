using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pendulum : MonoBehaviour
{
  public GameObject boat;
  public GameObject hook;
  public float force = 0;
  LineRenderer lineRenderer;
    // Start is called before the first frame update
    void Start()
    {
      lineRenderer = gameObject.GetComponent<LineRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        lineRenderer.SetPosition(1, hook.transform.position);
        lineRenderer.SetPosition(0, boat.transform.position);
        hook.GetComponent<Rigidbody>().AddForce(force,0,0);
    }
}
