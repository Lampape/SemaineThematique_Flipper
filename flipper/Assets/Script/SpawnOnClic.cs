using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnOnClic : MonoBehaviour
{
    public GameObject UnitSpawn;
    private GameObject UnitInstance;
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
        // je recupere le transform du spawner choisi dans l'index
        Vector3 aleaSpawn = allSpawner[nrbaleatoir].transform.position;
        // je spawn une instance d'ennemi
        if (Input.GetMouseButtonDown(0))
        {
            UnitInstance = Instantiate(UnitSpawn, aleaSpawn, Quaternion.identity);
            // je l'active dans la scene
            UnitInstance.SetActive(true);
            Debug.Log("ca c'est le chiffre hala =  " + aleaSpawn);

            
        }
    }
}
