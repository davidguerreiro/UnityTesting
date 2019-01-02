using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("Cube").GetComponent<PlayerHealth>().lives = 7;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
