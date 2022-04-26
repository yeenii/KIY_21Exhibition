using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ShowCrossText : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject roadText;

	private void Start()
	{
        roadText.SetActive(false);
    }

	public void OnPointerEnter(PointerEventData eventData)
    {
        roadText.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        roadText.SetActive(false);
    }
}
