﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // basic check collision
    void OnCollisionEnter(Collision col )
    {
        if ( col.gameObject.tag == "Enemy" ) {
            Destroy( col.gameObject );
        }
    }
}
