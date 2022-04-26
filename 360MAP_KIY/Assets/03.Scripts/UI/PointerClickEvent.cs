using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PointerClickEvent : MonoBehaviour
{
    public GameObject PopupUI;
    public GameObject nextUI;
    private bool status;
    public new SpriteRenderer renderer;
    GameObject pointob;
    Transform pointsize;


    private void Start()
    {
        PopupUI.SetActive(false);
        status = false;

        renderer = GetComponent<SpriteRenderer>();
        pointob = GameObject.Find("pointer");
        pointsize = pointob.GetComponent<Transform>();

        
    }


    private void OnMouseDown()
    {
        if (!EventSystem.current.IsPointerOverGameObject())
        {
            // �˾� UI ����
            if (status == false)
            {
                PopupUI.SetActive(false);
                status = true;
            }
            else
            {
                PopupUI.SetActive(true);
                nextUI.SetActive(false);
                status = false;
            }
        }
    }

    private void OnMouseOver()
    {
        if (!EventSystem.current.IsPointerOverGameObject())
        {
            // ���� ����
            //renderer.color = new Color(1,1,1,0.4f);
            // ũ�� ����
            transform.localScale = new Vector3(0.4f, 0.4f, 1);
            // ���� ���� (����)
            //renderer.color = new Color(0,0,0,0.4f);
        }
    }

    private void OnMouseExit()
    {
        if (!EventSystem.current.IsPointerOverGameObject())
        {
            // ����, ���� ����
            //renderer.color = new Color(1, 1, 1, 1);
            //ũ�� ����
            transform.localScale = new Vector3(0.3f, 0.3f, 1);
        }
    }

}
