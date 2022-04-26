using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    public CameraController cameraController;
    public int target_index = 0;

    private void OnMouseDown()
    {
            cameraController.changeView(target_index);
    }
}
