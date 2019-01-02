using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Bullets.noOfBullets = 20;
        // print( Bullets.noOfBullets );

        Bullets inst1 = new Bullets();
        Bullets inst2 = new Bullets();

        Debug.Log( Bullets.noOfBullets );
        Debug.Log( Bullets.ShowBullets() );
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public class Bullets {
    public static int noOfBullets = 0;

    public Bullets() {
        noOfBullets++;
    }

    public static int ShowBullets() {
        return noOfBullets;
    }
}
