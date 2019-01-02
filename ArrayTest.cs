using UnityEngine;

public class ArrayTest : MonoBehaviour
{
    public GameObject[] objects;
    public Color[] colors;

    // Start is called before the first frame update
    void Start() {
        for ( int i = 0; i < colors.Length; i++ ) {
            objects[i].GetComponent<Renderer>().material.color = colors[i];
        }
    }

    // Update is called once per frame
    void Update() {
      
    }
}
