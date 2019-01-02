using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineTest : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        // the string is the name of the coroutine function.
        // StartCoroutine("Test");
        Test2();

        for ( int i = 0; i <  6; i++ ) {
            print( "Start()" );
        }

        // passing a parameter to a coroutine.
        StartCoroutine("Test3", 4);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // this is the setTimeOut in C#.    
    IEnumerator Test() {
        print ( "CoRoutine Starts" );

        yield return new WaitForSeconds( 2f );
        GetComponent<Renderer>().material.color = Color.red;

        yield return new WaitForSeconds( 2f );
        GetComponent<Renderer>().material.color = Color.green;

        // hold for one frame.
        yield return null;

        print( "Coroutine ends");
    }

    void Test2() {
        for ( int i = 0; i < 6; i++ ) {
            print( "Test2()" );
        }
    }

    IEnumerator Test3( int times ) {
        for ( int i = 0; i < times; i++ ) {
            print( "Test3()" );
            yield return null;
        }
    }
}
