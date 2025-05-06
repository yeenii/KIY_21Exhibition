using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HP : MonoBehaviour
{
    public static HP Instance;

    public Slider hp;
    public static float maxHp = 100;
    public static float plusHp = 0;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        TryFindSlider();
        UpdateHpUI();
    }

    void Update()
    {
        if (hp == null)
        {
            TryFindSlider();
            UpdateHpUI();
        }
    }

    public void ControlHp()
    {
        plusHp += 10;
        UpdateHpUI();
    }

    //private void UpdateHpUI()
    //{
    //    if (hp != null)
    //        hp.value = plusHp / maxHp;
    //}
    private void UpdateHpUI()
    {
        if (hp != null)
        {
            hp.value = plusHp / maxHp;
        }

    }


    private void TryFindSlider()
    {
        if (hp == null)
        {
            Transform sliderTransform = GameObject.Find("GameHp")?.transform.Find("GameUI/Slider");
            if (sliderTransform != null)
            {
                hp = sliderTransform.GetComponent<Slider>();
            }
        }
    }
}
