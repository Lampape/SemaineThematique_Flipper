using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class storeScore : MonoBehaviour
{
    public static float scoreData;
    public static float combosData;

    // Update is called once per frame
    void Update()
    {
        if (TimerGain.gameOver == true)
        {
          scoreData = KillEnemie.scoreTotal;
          combosData = Billevelocity.velocityScore;
        }
    }
}
