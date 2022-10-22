using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour {

    [SerializeField] float delay = .5f;
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] AudioClip crashSFX;
    bool playedSound = false;

    void ReloadScene() {
        playedSound = false;
        SceneManager.LoadScene(0);
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Ground" && !playedSound) {
            playedSound = true;
            FindObjectOfType<***REMOVED***>().DisableControls();
            crashEffect.Play();
            GetComponent<AudioSource>().PlayOneShot(crashSFX);
            Invoke("ReloadScene", delay);
        }
    }
}
