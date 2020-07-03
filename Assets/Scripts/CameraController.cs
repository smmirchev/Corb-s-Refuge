using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float sensitivity = 3;
    public Transform target;
    public float diatanceTarget = 2;
    public Vector2 minMax = new Vector2(-30, 50);

    public float rotateTime = 0.1f;
    Vector3 rotate;
    Vector3 currentRotation;

    float mouseX;
    float mouseY;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        bool rotateCamera = Input.GetKey(KeyCode.Mouse1);

        if (rotateCamera)
        {
            mouseX += Input.GetAxis("Mouse X") * sensitivity;
            mouseY -= Input.GetAxis("Mouse Y") * sensitivity;
            mouseY = Mathf.Clamp(mouseY, minMax.x, minMax.y);


            currentRotation = Vector3.SmoothDamp(currentRotation, new Vector3(mouseY, mouseX), ref rotate, rotateTime);
            transform.eulerAngles = currentRotation;
        }


            transform.position = target.position - transform.forward * diatanceTarget; 
    }
}
