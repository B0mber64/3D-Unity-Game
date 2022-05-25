using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSensitivity = 600f;
    public Transform playerBody;
    float xRotation = 0f;
    // Start is called before the first frame update
    void Start()
    {
        // When clicking in the game your mouse is hidden, hit esc to re-enable it
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        // Alters the xRotation negatively, otherwise it will be backwards
        xRotation -= mouseY;
        // Locks camera so that you can not look to far on the Y axis
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        //Quaternions are responsible for rotation in Unity, using this lets you use the Mathf.Clamp
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
