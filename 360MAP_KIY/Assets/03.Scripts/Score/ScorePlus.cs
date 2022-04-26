using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScorePlus : MonoBehaviour
{
    public float ScoreDelay = 0.5f;
   

    // Use this for initialization
    void Start()
    {
        StartCoroutine("DisplayScore");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.y += 0.003f;
        transform.position = pos;
    }
    IEnumerator DisplayScore()
    {
        yield return new WaitForSeconds(ScoreDelay);

        for (float a = 1; a >= 0; a -= 0.05f)
        {
           
            yield return new WaitForFixedUpdate();
        }

        Destroy(gameObject);
    }

}
