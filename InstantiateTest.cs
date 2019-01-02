using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateTest : MonoBehaviour
{
    public GameObject[] ball;

    // Start is called before the first frame update
    void Start()
    {      
        // Invoke( "RandomBall", 5f );
        InvokeRepeating( "RandomBall", 1f, 1f );
    }

    // Update is called) once per frame
    void Update()
    {
        if ( Input.GetMouseButtonDown(0) ) {
            // RandomBall();
            CancelInvoke( "RandomBall" );
        }
    }

    // random ball generator.
    void RandomBall() {
        int randomNumber = Random.Range(0, ball.Length );
        Instantiate( ball[randomNumber], transform.position, Quaternion.identity );
        
    }
}
