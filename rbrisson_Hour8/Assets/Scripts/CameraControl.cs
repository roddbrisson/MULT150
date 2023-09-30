using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public float turnSpeed = 50f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mxVal = Input.GetAxis("Mouse X");
        float myVal = Input.GetAxis("Mouse Y");
        if (mxVal < 0)
            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
        if (mxVal > 0)
            transform.Rotate(Vector3.down, turnSpeed * Time.deltaTime);
        if (myVal > 0)
            transform.Rotate(Vector3.right, -turnSpeed * Time.deltaTime);
        if (myVal < 0)
            transform.Rotate(Vector3.left, -turnSpeed * Time.deltaTime);
    }
}
