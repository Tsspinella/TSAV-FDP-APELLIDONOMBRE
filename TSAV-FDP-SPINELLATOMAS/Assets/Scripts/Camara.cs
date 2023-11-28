using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara1 : MonoBehaviour
{
    float sensX = 200;
    float sensY = 200;

    public Transform orientation;

    float xRotation;
    float yRotation;

    private void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked; 
        Cursor.visible = false;
    }

    private void Update()
    {
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;

        yRotation += mouseX;
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -65f, 65f);

        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        orientation.rotation = Quaternion.Euler(0, yRotation, 0);
    }

}
