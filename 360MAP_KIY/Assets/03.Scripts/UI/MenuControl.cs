using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MenuControl : MonoBehaviour, IPointerDownHandler
{
    public GameObject btn;
    bool status;

    void Start()
    {
        btn.SetActive(false);
        status = true;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if(status==true)
		{
            btn.SetActive(true);
            status = false;
        }
		else
		{
            btn.SetActive(false);
            status = true;
        }
    }
}
