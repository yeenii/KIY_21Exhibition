using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MoveUI : MonoBehaviour
{
    public void StartUI()
    {
        SceneManager.LoadScene("startUI");
    }

    public void minimap()
    {
        SceneManager.LoadScene("minimap");
    }
}
