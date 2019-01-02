using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateWithMouse : MonoBehaviour
{
    public float rotationSpeed;
    void OnMouseDrag()
    {
        float x = Input.GetAxis( "Mouse X" ) * rotationSpeed;
        float y = Input.GetAxis( "Mouse Y" ) * rotationSpeed;

        // transform the Y axis.
        transform.Rotate( Vector3.right, y );

        // transform the X axis -  but default was inverted so we use a negative number.
        transform.Rotate( Vector3.up, -x );
    }
}
