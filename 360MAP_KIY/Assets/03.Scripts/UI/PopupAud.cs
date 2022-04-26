using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupAud : MonoBehaviour
{
    public GameObject obj;

    public AudioSource myAudio;

    public AudioClip nextAudio;
    public AudioClip returnAudio;

    public void NextSound()
    {
        myAudio.PlayOneShot(nextAudio);
        
    }

    public void ReturnSound()
    {
   
        myAudio.PlayOneShot(returnAudio);
        Invoke("ClickR",0.45f);
    }

    public void ClickR()
    {
        obj.SetActive(false);
    }

    
}
