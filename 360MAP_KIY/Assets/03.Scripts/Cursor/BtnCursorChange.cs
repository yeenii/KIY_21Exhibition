using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class BtnCursorChange : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
	public Texture2D cursorMode;

    public void OnPointerEnter(PointerEventData eventData)
    {
        Cursor.SetCursor(cursorMode, Vector2.zero, CursorMode.ForceSoftware);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Cursor.SetCursor(null, Vector2.zero, CursorMode.ForceSoftware);
    }
}
