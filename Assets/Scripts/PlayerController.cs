using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    Rigidbody2D rigid;
    [SerializeField] float torqueAmount = 1f;

    void Start() {
        rigid = GetComponent<Rigidbody2D>();
    }

    void Update() {
        if (Input.GetKey(KeyCode.LeftArrow)) {
            rigid.AddTorque(torqueAmount);
        } else if (Input.GetKey(KeyCode.RightArrow)) {
            rigid.AddTorque(-torqueAmount);
        }

    }
}
