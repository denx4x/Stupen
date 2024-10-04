using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeDestroyer : MonoBehaviour {
    void OnCollisionEnter(Collision collision) {
        var gameObject = collision.gameObject;
        Destroy(gameObject);
    }
}
