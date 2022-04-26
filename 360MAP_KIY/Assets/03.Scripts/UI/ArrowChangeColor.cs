using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ArrowChangeColor : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Image arrow;

    private void Start()
    {
       
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        arrow.GetComponent<Image>().color = new Color32(53, 50, 50, 255);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        arrow.GetComponent<Image>().color = new Color(1, 1, 1, 1);
    }
}
