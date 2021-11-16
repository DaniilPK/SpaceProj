using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float mouseSensitivity;

    public Transform playerBody;
    float rotationY;
    private float xRotation = 0f;


    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    public Transform cam;
    void Update()
    {
       float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
     
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
     
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -40f, 40f);
        transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
        playerBody.Rotate(Vector3.up * mouseX);
}
}
