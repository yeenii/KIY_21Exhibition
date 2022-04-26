using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class HoverOb : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject ob;

	private void Start()
	{
        ob.SetActive(false);
	}

	public void OnPointerEnter(PointerEventData eventData)
    {
        ob.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        ob.SetActive(false);
    }
}
