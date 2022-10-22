using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour {

    [SerializeField] float delay = .5f;
    [SerializeField] ParticleSystem crashEffect;

    void ReloadScene() {
        SceneManager.LoadScene(0);
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Ground") {
            crashEffect.Play();
            Invoke("ReloadScene", delay);
        }
    }
}
