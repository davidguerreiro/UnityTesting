// using System.Collections;
// using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{   
    public bool killPlayer = false;

    // Start is called before the first frame update.
    void Start() {
        if ( killPlayer ) {
            Destroy( gameObject, 2f );
        }

        print(gameObject);
        
    }

    // Update is called once per frame.
    void Update() { 
       
    }

    // returns double of value passed.
    int GiveMeDouble( int number )
    {
        return (number * 2);
    }

    // print char name.
    void PrintName( string name)
    {
        print("My name is: " + name);
    }

}
