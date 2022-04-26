using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DontDestroy : MonoBehaviour
{
    public static DontDestroy instance = null;

    public static DontDestroy Instance
    {
        get
        {
            return instance;
        }
    }

    void Awake()
    {
       
        
            if (instance)
            {
                DestroyImmediate(gameObject);
                return;
            }
            instance = this;
            DontDestroyOnLoad(gameObject);
        
       
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
