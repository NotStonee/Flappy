using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePipes : MonoBehaviour {
    public float moveSpeed = 5;
    public float offScreen = -20;
    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        //multiplying by deltaTime keeps the speed constant regardless of frames
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
        if (transform.position.x < offScreen) {
            Destroy(gameObject);
        }
    }
}
