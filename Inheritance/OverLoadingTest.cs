using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverLoadingTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Fun fun = new Fun();

        /*
        fun.printFloat( 2.5f );
        fun.printInt( 20 );
        fun.printString( "This is an string madafaka" );
        */

        fun.Print( 2 );
        fun.Print( 2.5f );
        fun.Print( "this is an string madafaka" );

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public class Fun {
    public void printInt (int i ) {
        Debug.Log( i );
    }

    public void printFloat( float i ) {
        Debug.Log( i );
    }

    public void printString ( string i  ) {
        Debug.Log( i );
    }

    public void Print( int i ) {
        Debug.Log( "this is the int one" );
    }

    public void Print( float i ) {
        Debug.Log( "this is the float one" );
    }

    public void Print( string i ) {
        Debug.Log( "this is the string one" );
    }
}
