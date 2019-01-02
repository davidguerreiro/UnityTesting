using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionTest : MonoBehaviour
{
    Vector3 pos;
    public float speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        pos = new Vector3( 1f, 2f, 3f );
        //transform.position += new Vector3(1f, 0, 0);
        
    }

    // Update is called once per frame
    void Update()
    {
        // transform.position += transform.forward * speed;
        // transform.Translate( speed, 0, 0 );
        // transform.Rotate( speed, speed, 0 );
        if ( transform.localScale.y < 20f ) {
            transform.localScale += new Vector3( 0, 1f, 0 );
        }
    }
}
