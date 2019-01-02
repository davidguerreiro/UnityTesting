using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputTest : MonoBehaviour
{   
    public float speed = 1f;
    public GameObject ball;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        // Keyboard Input.
        /*
        if ( Input.GetKeyDown( KeyCode.Space ) ) {
            print( "Pressed first time" );
            GetComponent<Renderer>().material.color = Color.green;
        }

        if ( Input.GetKeyUp( KeyCode.Space ) ) {
            print( "Released key" );
            GetComponent<Renderer>().material.color = Color.yellow;
        }

        if ( Input.GetKey( KeyCode.Space ) ) {
            print( "Pressing the key button" );
            GetComponent<Renderer>().material.color = Color.red;
        }
        

        if ( Input.GetButtonDown("Jump") ) {
            GetComponent<Renderer>().material.color = Color.blue;
        }

        if ( Input.GetButtonUp("Jump") ) {
            GetComponent<Renderer>().material.color = Color.white;
        }

        */

        float xInput = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float yInput = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        transform.Translate( xInput, yInput, 0 );


        // mouse input.
        if ( Input.GetButtonDown("Fire1") ) {
            print( "Clicking the mouse" );

            print( Input.mousePosition.x + " " + Input.mousePosition.y );

            Vector3 pos = Input.mousePosition;
            pos.z = 10f;

            pos = Camera.main.ScreenToWorldPoint( pos );

            Instantiate( ball, pos, Quaternion.identity);
        }

        if ( Input.GetMouseButtonDown(0) ) {
            print( "Left click" );
        }

        if ( Input.GetMouseButtonDown(1) ) {
            print( "Right Click" );
        }

        if ( Input.GetMouseButtonDown(2) ) {
            print( "Wheel pressed" );
        }
    }

    
    void OnMouseDown()
    {
        Destroy( gameObject );
    }
}
