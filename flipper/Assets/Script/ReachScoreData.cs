using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ReachScoreData : MonoBehaviour
{
    public Text scoreText;
    public Text combosText;
    
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Score : " +storeScore.scoreData;
        combosText.text = "Combos : " + storeScore.combosData;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
