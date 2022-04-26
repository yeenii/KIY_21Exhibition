using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GoToScene1 : MonoBehaviour
{

    private void OnMouseDown()
    {
        SceneManager.LoadScene("scene01");
    }

    public void goStart()
	{
        SceneManager.LoadScene("scene01");
    }
}
