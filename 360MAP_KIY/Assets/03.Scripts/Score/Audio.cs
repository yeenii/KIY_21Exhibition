using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    public GameObject obj;
    public AudioSource myAudio;
    public AudioClip hoborAudio;
    public AudioClip clickAudio;



    public void HoborSound()
    {
           
            myAudio.PlayOneShot(hoborAudio);
        
    }

   
    public void ClickSound()
    {
        myAudio.PlayOneShot(clickAudio);
        Invoke("ClickD", 0.45f);
    }

    public void ClickD()
    {

        obj.SetActive(false);
    }

    

}
