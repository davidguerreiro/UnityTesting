using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    GameObject searchObj;
    GameObject[] enemies;

    // Start is called before the first frame update
    void Start()
    {
        //searchObj = GameObject.Find("Cube/Cube2/Enemy");
        // searchObj = GameObject.FindWithTag( "Enemy" );
        enemies = GameObject.FindGameObjectsWithTag("Enemy");
        //Destroy(searchObj);

        foreach ( GameObject enemy in enemies ) {
            Destroy(enemy);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
