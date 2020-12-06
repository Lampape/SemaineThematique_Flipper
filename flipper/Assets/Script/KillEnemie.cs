using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class KillEnemie : MonoBehaviour
{
    public int scoreGiven = 5;
    public int scoreTotal;
    private int killCount;
    public Text scoreText;
    public Text combosText;

    public void Update()
    {
        scoreTotal = scoreGiven * killCount * Billevelocity.velocityScore;
        scoreText.text = "score : " + scoreTotal;
        combosText.text = "combos : " + Billevelocity.velocityScore;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("BilleFlipper"))
        {
            killCount++;
            Destroy(other.gameObject);
        }
    }
}