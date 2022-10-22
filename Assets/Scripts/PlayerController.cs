using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ***REMOVED*** : MonoBehaviour {
    Rigidbody2D rigid;
    [SerializeField] float torqueAmount = 5000f;
    [SerializeField] float boostSpeed = 50f;
    [SerializeField] float baseSpeed = 20f;
    SurfaceEffector2D surfaceEffector;
    bool canMove = true;


    void RotatePlayer() {
        if (Input.GetKey(KeyCode.LeftArrow)) {
            rigid.AddTorque(torqueAmount * Time.deltaTime);
        } else if (Input.GetKey(KeyCode.RightArrow)) {
            rigid.AddTorque(-torqueAmount * Time.deltaTime);
        }
    }

    public void DisableControls() {
        canMove = false;
    }

    void RespondToBoost() {
        if (Input.GetKey(KeyCode.UpArrow)) {
            surfaceEffector.speed = boostSpeed;
        } else if (!Input.GetKey(KeyCode.UpArrow)) {
            surfaceEffector.speed = baseSpeed;
        }
    }

    void Start() {
        surfaceEffector = FindObjectOfType<SurfaceEffector2D>();
        rigid = GetComponent<Rigidbody2D>();
    }

    void Update() {
        if (canMove) {
            RotatePlayer();
            RespondToBoost();
        }
    }
}
