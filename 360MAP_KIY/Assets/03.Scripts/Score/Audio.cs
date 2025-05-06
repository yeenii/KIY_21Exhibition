using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    public GameObject obj; //캐릭터 GameObject
    public AudioSource myAudio; //AudioSource
    public AudioClip hoborAudio; //horbor 효과음
    public AudioClip clickAudio; //click 효과음

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
