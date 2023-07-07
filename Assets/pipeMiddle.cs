using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeMiddle : MonoBehaviour {
    public gameInfo logic;
    // Start is called before the first frame update
    void Start() {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<gameInfo>();
    }

    // Update is called once per frame
    void Update() {
        
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.layer == 3) {
            logic.addScore();
        }
    }
}
