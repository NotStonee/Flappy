using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {
    public Rigidbody2D  myRigidbody;
    public float flapStrength;
    public gameInfo logic;
    public bool birdIsAlive = true;

    // Start is called before the first frame update
    void Start() {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<gameInfo>();
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0) && birdIsAlive) {
            myRigidbody.velocity = Vector2.up * flapStrength;
        }

        if (birdIsAlive == false) {
            flapStrength = 0;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision) {
        logic.gameOver();
        birdIsAlive = false;
    }
}
