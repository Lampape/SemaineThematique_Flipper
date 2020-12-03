using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnOnClic : MonoBehaviour
{
    public GameObject UnitSpawn;

    public GameObject[] allSpawner;

    private int compteList;
    // Update is called once per frame
    private void Start()
    {
        // le nombre de spawner
        compteList = allSpawner.Length;
        Debug.Log(" ca c le comptelsit =  " +compteList);
    }

    void Update()
    {
        // je spawn un nrb aléatoire
        int nrbaleatoir = Random.Range(0 ,compteList );
        // jerecupere le transform du psawner chosie dans l'index
        Vector3 aleaSpawn = allSpawner[nrbaleatoir].transform.position;
        // je le spawn
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(UnitSpawn,aleaSpawn, Quaternion.identity);
            Debug.Log("ca c'est le chiffre hala =  " + aleaSpawn);
        }
    }
}
