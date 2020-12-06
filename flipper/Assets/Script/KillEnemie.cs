using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class KillEnemie : MonoBehaviour
{
    public int scoreGiven = 5;
    public static  int scoreTotal;
    private int killCount;
    public Text scoreText;
    public Text combosText;
    public int timeGiven;

    public void Update()
    {
        scoreText.text = "score : " + scoreTotal;
        combosText.text = "combos : " + Billevelocity.velocityScore;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("BilleFlipper"))
        {
            
            killCount++;
            Destroy(other.gameObject);
            TimerGain.timerTotal += timeGiven ;
            scoreTotal += scoreGiven * killCount * Billevelocity.velocityScore;
        }
    }
}