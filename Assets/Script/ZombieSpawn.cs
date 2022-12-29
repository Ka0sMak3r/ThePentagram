using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawn : MonoBehaviour
{
    public PuzzleScript PuzzleScript;
    public List<GameObject> zombies = new List<GameObject>();
    //public GameObject zomb;
    public List<Transform> zspawn = new List<Transform>();
    //public Transform zspawn;
    public void spawnZ()
    {

            Debug.Log("Working but need to Connect ");
            int zombieIndex = Random.Range(0, zombies.Count);
            for (int i = 0; i < 5; i++)
            {
                Instantiate(zombies[zombieIndex], zspawn[i].position, zspawn[i].rotation);
            }
        
        
    }
}
