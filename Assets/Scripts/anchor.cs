using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class anchor : MonoBehaviour
{
    public scoreScript scoreScript;
    public healthScript healthScript;
    public Vector3 properties;
    // Start is called before the first frame update
    void Start()
    {

    }
    private void OnTriggerEnter(Collider other)
    {//box collider center, x = worth, y = enemy - 0 for false and 1 for true
      properties = other.GetComponent<BoxCollider>().center;
      scoreScript.scoreValue += (int) properties.x;
      if(properties.y == 1)
      {
        healthScript.healthValue--;
        if(healthScript.healthValue == 0)
        {
          SceneManager.LoadScene(0);
        }
      }
      Destroy(other.gameObject);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
