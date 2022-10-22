using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ***REMOVED*** : MonoBehaviour {
    Rigidbody2D rigid;
    [SerializeField] float torqueAmount = 5000f;

    void Start() {
        rigid = GetComponent<Rigidbody2D>();
    }

    void Update() {
        if (Input.GetKey(KeyCode.LeftArrow)) {
            rigid.AddTorque(torqueAmount * Time.deltaTime);
        } else if (Input.GetKey(KeyCode.RightArrow)) {
            rigid.AddTorque(-torqueAmount * Time.deltaTime);
        }

    }
}
