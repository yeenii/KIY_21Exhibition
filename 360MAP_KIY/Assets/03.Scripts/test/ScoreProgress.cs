using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreProgress : MonoBehaviour
{
    public static float score;

    public void scoreUp()
	{
		score += 0.1f;
	}
}
