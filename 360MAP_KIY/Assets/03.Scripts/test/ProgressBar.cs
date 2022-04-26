using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    public Image LoadingBar;

    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        LoadingBar.fillAmount = ScoreProgress.score;

    }
}
