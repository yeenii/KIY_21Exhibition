using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreReset : MonoBehaviour
{
    HP HP;
    ScoreUI ScoreUI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HP = GameObject.Find("TextObject").GetComponent<HP>();
        ScoreUI = GameObject.Find("TextObject").GetComponent<ScoreUI>();

       
    }

    public void Reset()
    {
        HP.plusHp = 0;
        ScoreUI.Score = 0;
    }
}
