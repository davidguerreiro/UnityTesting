using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// scene management.
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public int sceneNumber;
    // Start is called before the first frame update
    void Start()
    {
        print( "Level Loaded" );
    }

    // Update is called once per frame
    void Update()
    {
        if ( Input.GetMouseButtonDown( 0 ) ) {
            // LoadLevel();

            RestartLevel();
        }
    }

    void LoadLevel() {
        // scenes have to be added to build settings in File -> build settings.
        //SceneManager.LoadScene( "level2" );
        SceneManager.LoadScene( sceneNumber );
    }

    void RestartLevel() {
        SceneManager.LoadScene( SceneManager.GetActiveScene().buildIndex );
    }
}
