using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonCamera : MonoBehaviour
{
    // Vairiables
    public Transform player;
    public float mouseSensitivity = 2f;
    float cameraVerticalRotation = 0;

    bool lockedCursor = true;
    
    
    void Start()
    {
         Cursor.visible = false;
         Cursor.lockState = CursorLockMode.Locked;
    }

   
    void Update()
    {
        float inputX = Input.GetAxis("Mouse X")* mouseSensitivity;
        float inputY = Input.GetAxis("Mouse Y")* mouseSensitivity;


        // Camera X as
        cameraVerticalRotation -= inputY;
        cameraVerticalRotation = Mathf.Clamp(cameraVerticalRotation, -90f, 90f);
        transform.localEulerAngles = Vector3.right * cameraVerticalRotation;

        player.Rotate(Vector3.up * inputX);
    }
}
