using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;


public class ItemRandomizer : MonoBehaviour
{
    //public Transform[] items;
    //float _time = 10f;
    // public Transform[] spawnpoints;
    //private bool doonce = false;
    public List<GameObject> items = new List<GameObject>();
    public List<Transform> spawnpoints = new List<Transform>();


    private void Start()
    {
        for (int i = 0; i < spawnpoints.Count; i++)
        {
                int objectIndex = Random.Range(0, items.Count);
                Instantiate(items[objectIndex], spawnpoints[i].position, spawnpoints[i].rotation);
                items.RemoveAt(objectIndex);
        }
    }
   
    void Update()
    {

    }


}
