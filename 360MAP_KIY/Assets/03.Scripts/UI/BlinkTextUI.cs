using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlinkTextUI : MonoBehaviour
{
    float time;


    void Update()
    {
        if(time <0.8f)
		{
            GetComponent<Text>().color = new Color(1, 1, 1, 1 - time);
		}
		else
		{
            GetComponent<Text>().color = new Color(1, 1, 1, time);
            if(time >1f)
			{
                time = 0;
			}
        }
        time += Time.deltaTime;
    }
}
