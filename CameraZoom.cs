using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{

    public int zoomSpeed2D;
    public int minZoom2d;
    public int maxZoom2d;

    public int maxZoom3d;
    public int minZoom3d;

    public int zoomSpeed3D;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ( Camera.main.orthographic ) {
            // 2D Camera - uses size parameter.
            twoDCameraZoomController();
        } else {
            // 3D Camera
            threeDCameraZoomController();
        }
        
    }

    public void twoDCameraZoomController() {
        // scroll up the mouse wheel.
        if ( Input.GetAxis( "Mouse ScrollWheel" ) > 0 ) {
            // ZoomIn.
            Camera.main.orthographicSize -= zoomSpeed2D * Time.deltaTime;
        }

        // scroll down the mouse wheel.
        if ( Input.GetAxis( "Mouse ScrollWheel" ) < 0 ) {
            // Zoom Out.
            Camera.main.orthographicSize += zoomSpeed2D * Time.deltaTime;
        }

        // Restrict the zoom value.
        Camera.main.orthographicSize = Mathf.Clamp( Camera.main.orthographicSize, minZoom2d, maxZoom2d );
    }

    public void threeDCameraZoomController() {
        // scroll up the mouse wheel.
        if ( Input.GetAxis( "Mouse ScrollWheel" ) > 0 ) {
            // ZoomIn.
            Camera.main.fieldOfView-= zoomSpeed3D * Time.deltaTime;
        }

        // scroll down the mouse wheel.
        if ( Input.GetAxis( "Mouse ScrollWheel" ) < 0 ) {
            // Zoom Out.
            Camera.main.fieldOfView += zoomSpeed3D * Time.deltaTime;
        }

        // Restrict the zoom value.
        Camera.main.fieldOfView = Mathf.Clamp( Camera.main.fieldOfView, minZoom3d, maxZoom3d );
    }
}
