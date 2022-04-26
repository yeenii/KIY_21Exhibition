using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayMouseControl : MonoBehaviour
{
    public float turnSpeed = 4.0f; // ���콺 ȸ�� �ӵ�
    public float moveSpeed = 2.0f; // �̵� �ӵ�
    public float zoomSpeed = 10.0f;

    private float xRotate = 0.0f; // ���� ����� X�� ȸ������ ���� ���� ( ī�޶� �� �Ʒ� ���� )
    private Camera mainCamera;


    public GameObject eventText;
    public GameObject scoreText;

    public GameObject btn;
    public GameObject menu;
    public GameObject pointer;

    public float delayMouse;
    public float hideText;
    public float showBtn;

    void Start()
    {
        mainCamera = GetComponent<Camera>();
    }

    void Update()
    {
        //MouseRotation();
        //Zoom();

        Invoke("MouseRotation", delayMouse);
        Invoke("Zoom", delayMouse);
        Invoke("HideText", hideText);
        Invoke("ShowBtn", showBtn);
    }

    private void Zoom()
    {
        float distance = Input.GetAxis("Mouse ScrollWheel") * -1 * zoomSpeed;
        if (distance != 0)
        {
            mainCamera.fieldOfView += distance;
        }
    }
    // ���콺�� �����ӿ� ���� ī�޶� ȸ�� ��Ų��.
    void MouseRotation()
    {
        if (Input.GetMouseButton(1))
        {
            // �¿�� ������ ���콺�� �̵��� * �ӵ��� ���� ī�޶� �¿�� ȸ���� �� ���
            float yRotateSize = Input.GetAxis("Mouse X") * turnSpeed;
            // ���� y�� ȸ������ ���� ���ο� ȸ������ ���
            float yRotate = transform.eulerAngles.y + yRotateSize;

            // ���Ʒ��� ������ ���콺�� �̵��� * �ӵ��� ���� ī�޶� ȸ���� �� ���(�ϴ�, �ٴ��� �ٶ󺸴� ����)
            float xRotateSize = -Input.GetAxis("Mouse Y") * turnSpeed;
            // ���Ʒ� ȸ������ ���������� -45�� ~ 80���� ���� (-45:�ϴù���, 80:�ٴڹ���)
            // Clamp �� ���� ������ �����ϴ� �Լ�
            xRotate = Mathf.Clamp(xRotate + xRotateSize, -45, 80);

            // ī�޶� ȸ������ ī�޶� �ݿ�(X, Y�ุ ȸ��)
            transform.eulerAngles = new Vector3(xRotate, yRotate, 0);
        }

    }

    private void HideText()
	{
        eventText.SetActive(false);
        scoreText.SetActive(false);

    }

    private void ShowBtn()
	{
        btn.SetActive(true);
        menu.SetActive(true);
        pointer.SetActive(true);

	}
}
