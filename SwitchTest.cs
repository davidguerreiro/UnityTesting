using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchTest : MonoBehaviour
{
    public int power = 0;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        switch(power) {
            case 0:
               print("Chacho pawer is sero");
               break;
            case 1:
                print("Chacho pawer is more");
                break;
            default:
                print("Cacho much pawer");
                break;
        }
    }
}
