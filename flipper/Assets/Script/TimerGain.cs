using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerGain : MonoBehaviour
{
    public float tempsDepart = 60.0f;
    private float timer;
    public static bool gameOver;
    public static float timerTotal;
    public Text timerText;
    // Start is called before the first frame update
    void Start()
    {
        gameOver = false;
        timer = 0;
        timerTotal = tempsDepart;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver==false)
        {
            timer += Time.deltaTime;
            if (timer > 1.0f)
            {
                timerTotal--;
                timer = timer - 1.0f;
            }

            if (timerTotal<= 0.0f)
            {
                gameOver = true;
                Debug.Log("game over");
            }
            timerText.text = "Temps restant  = " + timerTotal ;
        }
        
        
    }
}
