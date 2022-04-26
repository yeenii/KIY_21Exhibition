using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
   
    public Text scoreText;
    public static int Score = 0;
    

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = Score.ToString("0")+" / 10";

    }

    public void ScoreUp()
    {
      
        if (Score <= 9)
        {
            Score += 1;
        }
        else
        {
            Score = 10;
        }
    }

    

   
    
}
