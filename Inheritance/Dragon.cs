using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragon : MonoBehaviour {
    
    // virtal makes this class to be able to be overwritten by children classes.
    public virtual void Attack() {
        print( "Dragon attack" );
    }

    private void Start() {
        // Dragon dragon = new Dragon();
        // dragon.Attack();

        Dragon dragon3 = new Dragon();
        dragon3.Attack();
        Dragon dragon = new BlueDragon();
        dragon.Attack();
        Dragon dragon2 = new RedDragon();
        dragon2.Attack();
    }
    /*
    Inherit from Enemy code
    
    public bool attacking = false;
    
    private void Update() {
        if ( attacking ) {
            base.Attack();
        }
    }

    void Attack() {
        print( "The dragon is attacking" );
    }
    */
} // End of dragon class.


public class BlueDragon : Dragon {

    // overrides Attack from parent.    
    public override void Attack() {
        print( "Blue Dragon Attack" );
    }
}

public class RedDragon : Dragon {

    public override void Attack() {
        print( "Red Dragon Attack" );
    }
}