using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PuzzleScript : MonoBehaviour
{
    public Transform[] cubes;
    public GameObject player;
    public ZombieSpawn zs;
    public Transform CP;

    void OnCollisionEnter(Collision cd)
    {

        if (cubes != null)
        {
            GameObject[] cubes = FindObjectsOfType<GameObject>() as GameObject[];

            if (cd.gameObject.CompareTag("Player"))
            {

                for (int i = 0; i < cubes.Length; i++)
                {
                    gameObject.SetActive(false);
                    cubes[i] = null;
                }
            }
        }
        if (cubes == null)
        {
            zs.spawnZ();
        }
    }





    
}