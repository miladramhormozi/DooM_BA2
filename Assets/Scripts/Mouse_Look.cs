using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse_Look : MonoBehaviour
{
    Transform mainCameraTransform;
    float verticalRotation;

    float mouseX;
    float mouseY;

    public float MaxVerticalRotation;
    public float MinVerticalRotation;

    public float MouseSensitivity;
    void Start()
    {
        mainCameraTransform = Camera.main.transform;
        
    }


    void Update()
    {
        mouseX = Input.GetAxis("Mouse X") * MouseSensitivity; //* Time.deltaTime;
        mouseY = Input.GetAxis("Mouse Y") * MouseSensitivity; //*Time.deltaTime;

        verticalRotation -= mouseY;
        // verticalRotation = Mathf.Clamp(verticalRotation, MinVerticalRotation, MaxVerticalRotation);
        verticalRotation = Mathf.Clamp(verticalRotation, -MaxVerticalRotation, -MinVerticalRotation);

        transform.Rotate(Vector3.up, mouseX);
        mainCameraTransform.localRotation = Quaternion.Euler(verticalRotation, 0, 0);





    }
}
