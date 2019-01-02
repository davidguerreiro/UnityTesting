using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopTest : MonoBehaviour
{
    public int forLoops = 1;
    public int whileLoop = 1;
    public GameObject[] objects;

    // Start is called before the first frame update
    void Start()
    {   
       for ( int i = 0; i <= forLoops; i++ ) {
            print( "This is loop: " + i );
        }
       
        while ( whileLoop <= 1 ) {
            print( "While loop is running" );
            whileLoop++;
        }

         foreach ( GameObject o in objects ) {
            o.SetActive( true );
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
