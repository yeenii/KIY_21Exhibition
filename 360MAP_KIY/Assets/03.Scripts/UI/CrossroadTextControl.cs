using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossroadTextControl : MonoBehaviour
{
    // 갈림길 텍스트를 컨트롤하는 스크립트

    public GameObject roadText;

    void Start()
    {
        roadText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	private void OnMouseOver()
	{
        roadText.SetActive(true);
    }

	private void OnMouseExit()
	{
        roadText.SetActive(false);
    }
}
