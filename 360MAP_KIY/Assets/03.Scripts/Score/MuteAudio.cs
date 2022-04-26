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
            //ȿ���� �� �鸮�� �ϱ�

        }
        else
        {
            mute = false;
            AudioListener.pause = false;
         
            //ȿ���� �鸮�� �ϱ�
        }
        Save();
        UpdateButton();
    }


    private void UpdateButton()
    {
        // ���� �̹��� ����
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
