using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstPersonShooter : MonoBehaviour

{

    public float lookSensitivity = 2f, lookSmoothDamp = .5f;
    [HideInInspector]
    public float yRot, xRot;
    [HideInInspector]
    public float currentY, currentX;
    [HideInInspector]
    public float yRotationV, xRotationV;
    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        yRot += Input.getAxis("mouse X") * lookSensitivity;
        xRot += Input.getAxis("mouse Y") * lookSensitivity;

        currentX = Mathf.SmoothDamp(currentX, xRot, ref xRotationV, lookSmoothDamp);
        currentY = Mathf.SmoothDamp(currentY, yRot, ref yRotationV, lookSmoothDamp);

        xRot = Mathf.Clamp(xRot, -80, 80);

        transform.rotation = Quaternion.Euler(-currentX, currentY, 0);

        
    }
}
