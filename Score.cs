using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score
{
    private int point;
    private int lives;

    private int readOnly;

    public int Point {
        // getter.
        get {
            return point;
        }

        // setter.
        set {
            if ( value > 5 && value < 10 ) { 
                point = value;
            }
            PrintPoint();
        }
    }
    /*
        This creates a getter and a setter automatically.
        If you want to be read only, remove the set.
     */

    public int Lives { get; set; }
    // this one is read only.
    public int ReadOnly{ get; }

    void PrintPoint() {
        Debug.Log( point );
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
