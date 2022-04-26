using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MuteAudio : MonoBehaviour
{
    [SerializeField]
    Image soundOn;

    [SerializeField]
    Image SoundOff;

    private bool mute = false;

 

    void Start()
    {
        if (!PlayerPrefs.HasKey("mute"))
        {
            PlayerPrefs.SetInt("mute",0);
            Load();
        }
        else
        {
            Load();
        }
        UpdateButton();
        AudioListener.pause = mute;
    }

    public void OnOffPress()
    {
        if (mute == false) 
        {
            mute = true;
            AudioListener.pause = true;
            //효과음 안 들리게 하기

        }
        else
        {
            mute = false;
            AudioListener.pause = false;
         
            //효과음 들리게 하기
        }
        Save();
        UpdateButton();
    }


    private void UpdateButton()
    {
        // 사운드 이미지 변경
        if (mute == false)
        {
            soundOn.enabled = true;
            SoundOff.enabled = false;

        }
        else
        {
            soundOn.enabled = false;
            SoundOff.enabled = true;
        }

    }

    private void Load()
    {
        mute = PlayerPrefs.GetInt("mute") == 1;
    }

    private void Save()
    {
        PlayerPrefs.SetInt("mute", mute ? 1 : 0);
    }
}
