using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassTest : MonoBehaviour
{
    public Car myCar;
    
    // Start is called before the first frame update
    void Start()
    {
        /*
        Car myCar = new Car();
        myCar.speed         = 10.5f;
        myCar.color         = "Red";
        myCar.highestSpeed  = 20;

        Car suzuki = new Car();
        suzuki.speed        = 15f;
        suzuki.color        = "Green";
        suzuki.highestSpeed = 30;
        */

        Car CarTest = new Car( 11f, "Yellow", 25 );

        myCar.PrintCarDetails();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
