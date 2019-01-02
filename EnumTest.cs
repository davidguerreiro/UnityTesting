using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnumTest : MonoBehaviour
{
    /*
        With enum you can create your own type of variable.
        Each of the values have an internal value, from 0 to n.
        You can also give values manually.
        This is super useful to create states for the game, enemies, etc
     */
    public enum GameState{ Ready, Playing, Pause, GameOver };
    public GameState state;
    // Start is called before the first frame update
    void Start()
    {
        state = GameState.Ready;
    }

    // Update is called once per frame
    void Update()
    {
        checkState();
    }

    void checkState() {
        switch( state ) {
            case GameState.Ready:
                //print( "You are ready" );
                print( GameState.Ready );
                print( (int) GameState.Ready );
                break;
            case GameState.Playing:
                print( "Game Playing" );
                break;
            case GameState.Pause:
                print( "Game Paused" );
                break;
             case GameState.GameOver:
                print( "Game Over" );
                break;
        }
    }
}
