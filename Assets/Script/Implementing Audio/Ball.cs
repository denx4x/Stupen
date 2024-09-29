using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    [SerializeField]
    private AudioSource _bounceSFX;

    void OnCollisionEnter(Collision other) {
        _bounceSFX.Play();
    }


}
