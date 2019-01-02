using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsTest : MonoBehaviour
{
    public float speed = 1f;
    public float bulletSpeed = 1f;
    public int jumpForce = 1;
    public bool jump = false;
    public GameObject bullet;
    public Transform bulletPos;
    float inputX, inputY;
    bool shoot = false;
    
    Rigidbody rb;
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {
        // rb.velocity = new Vector3( 0, 0, speed );
    }

    // Update is called once per frame
    void Update()
    {
        inputX = Input.GetAxis( "Horizontal" );
        inputY = Input.GetAxis( "Vertical" );
        
        // check if we are clicking space bar jump button - see InputManager.
        if ( Input.GetButtonDown( "Jump" ) ) {
            jump = true;
        }

        if ( Input.GetButtonDown("Fire1") ) {
            shoot = true;
        }
    }

    void FixedUpdate() {
        rb.velocity = new Vector3( inputX * speed, rb.velocity.y, inputY * speed );

        if ( jump ) {
            Jump();

            jump = false;
        }

        if ( shoot ) {
            Shoot();

            shoot = false;
        }
    }

    void Jump() {
        rb.AddForce(0, jumpForce, 0 );
    }

    void Shoot() {
        GameObject bulletSpawn = Instantiate( bullet, bulletPos.position, bullet.transform.rotation );
        bulletSpawn.GetComponent<Rigidbody>().velocity = new Vector3( 0, 0, bulletSpeed );
    }
}
