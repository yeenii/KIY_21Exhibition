using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalText : MonoBehaviour
{

    ScoreUI ScoreUI;

    public Text FText;
   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ScoreUI = GameObject.Find("TextObject").GetComponent<ScoreUI>();


        if (ScoreUI.Score >= 9)
        {
            FText.text = "Excellent!";
        }
        else if (ScoreUI.Score >= 5)
        {
            FText.text = "Great!";
        }
        else if (ScoreUI.Score >= 1)
        {
            FText.text = "Good job!";
        }
        else
        {
            FText.text = "Nice try!";
        }
    }
}
