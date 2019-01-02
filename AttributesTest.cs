using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent( typeof(Rigidbody) ) ]
public class AttributesTest : MonoBehaviour
{   
    // display fields into the editor.
    // [SerializeField]
    // hide in the inspector , even if the attribute is hidden.
    // [HideInInspector]
    // Modify attr as range.
    // [Range(0,20)]
    public int speed;

    Rigidbody rb;
    // Start is called before the first frame update.
    void Start() {
        rb = GetComponent<Rigidbody>();
    }  

    // Update is called once per frame.
    void Update()
    {
        transform.Translate( speed * Time.deltaTime, 0, 0 );
    }
}
