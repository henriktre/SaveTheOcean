using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pendulum : MonoBehaviour
{
  public backgroundScript backgroundScript;
  public GameObject boat;
  public GameObject hook;
  public float maxSpeed = 500.0f;
  public float minSpeed = 0.0f;
  public float maxLength = 8.0f;
  public float minLength = 1.0f;
  public float boatSpeed = 0.0f;
  public float ropeLength = 1.0f;
  public float boatPower = 250.0f;
  public float winchPower = 4.0f;
  LineRenderer lineRenderer;

    // Start is called before the first frame update
    void Start()
    {
      lineRenderer = gameObject.GetComponent<LineRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        lineRenderer.SetPosition(0, boat.transform.position);
        lineRenderer.SetPosition(1, hook.transform.position);
        hook.GetComponent<Rigidbody>().AddForce(boatSpeed*-1,0,0);
        boat.GetComponent<SpringJoint>().minDistance = ropeLength;

        if (Input.GetKey("a") && boatSpeed > minSpeed)
        {
            boatSpeed -= Time.deltaTime * boatPower;
        }
        if (Input.GetKey("d") && boatSpeed < maxSpeed)
        {
            boatSpeed += Time.deltaTime * boatPower;
        }
        if (Input.GetKey("w") && ropeLength > minLength)
        {
            ropeLength -= Time.deltaTime * winchPower;
        }
        if (Input.GetKey("s") && ropeLength < maxLength)
        {
            ropeLength += Time.deltaTime * winchPower;
        }
    }
}
