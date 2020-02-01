using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject[] entities;

    // Start is called before the first frame update
    void Start()
    {
      entities = Resources.LoadAll("MyItemsToLoad") as GameObject[];

    }

    // Update is called once per frame
    void Update()
    {

    }
}

[System.Serializable]
public class entity
{
  public int rarity;
  public int worth;
  public entity (int rarity, int worth)
  {

  }
}
