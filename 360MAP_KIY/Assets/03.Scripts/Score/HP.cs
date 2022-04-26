using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HP : MonoBehaviour
{
    public Slider hp;
    public static float maxHp = 100;
    public static float plusHp = 0;

    // Start is called before the first frame update
    void Start()
    {
        hp.value = (float)plusHp / (float)maxHp;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ControlHp()
    {
        plusHp += 10;
        HandleHp();

    }

    private void HandleHp()
    {
        hp.value = (float)plusHp / (float)maxHp;

    }
}
