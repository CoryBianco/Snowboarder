using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class FinishLine : MonoBehaviour {

    [SerializeField] float delay = 2f;
    [SerializeField] ParticleSystem finishEffect;

    void ReloadScene() {
        SceneManager.LoadScene(0);
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Player") {
            FindObjectOfType<*****>().DisableControls();
            finishEffect.Play();
            GetComponent<AudioSource>().Play();
            Invoke("ReloadScene", delay);
        }
    }
}
   
