using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnOnPass : MonoBehaviour
{
    public GameObject spawnUnit;
    public float coolDown;
    private float timer;
    private bool isSpawn;

    private bool goCreate;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 pos = transform.position;
        Instantiate(spawnUnit, pos, Quaternion.identity);
        isSpawn = true;
        goCreate = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("LaBille")&& !goCreate)
        {
            isSpawn = false;
            goCreate = true;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (isSpawn == false)
        {
            timer += Time.deltaTime;
            if (timer > coolDown)
            {
                if (goCreate==true )
                {
                    Vector3 pos = transform.position;
                    Instantiate(spawnUnit, pos, Quaternion.identity);
                    goCreate = false;
                }   
                isSpawn = true;
                timer = timer - coolDown;
            }
        }
    }
}
