using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstPerson : MonoBehaviour
{
    public float sensX;
    public float sensY;

    public Transform orientation;

    public float xrotation;
    public float yrotation;


    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
    {
       // get mouse input
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;

        yrotation += mouseX;

        xrotation -= mouseY;
        xrotation = Mathf.Clamp(xrotation, -90f, 90f);

        // rotate cam and orientation
        transform.rotation = Quaternion.Euler(xrotation, yrotation, 0);
        orientation.rotation = Quaternion.Euler(0, yrotation, 0);
    }
    


}
