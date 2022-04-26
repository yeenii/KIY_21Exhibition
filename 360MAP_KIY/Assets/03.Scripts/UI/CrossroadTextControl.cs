using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossroadTextControl : MonoBehaviour
{
    // ������ �ؽ�Ʈ�� ��Ʈ���ϴ� ��ũ��Ʈ

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
