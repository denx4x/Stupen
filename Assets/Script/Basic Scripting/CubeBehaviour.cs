using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBehaviour : MonoBehaviour {

    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        
        if (Input.GetKeyDown(KeyCode.R)) {
            UpdateRotation(new Quaternion());
        }

        if (Input.GetKeyDown(KeyCode.E)) {
            UpdateScale(new Vector3(-1,-1,-1));
        }

    }

    public void UpdatePosition(Vector3 newPosition) {
        transform.position = transform.position + newPosition;
    }

    void UpdateRotation(Quaternion rotation) {
        transform.rotation = transform.rotation * rotation;
    }

    void UpdateRotation1(Vector3 rotateVector) {
        transform.Rotate(rotateVector);
    }

    void UpdateScale(Vector3 scale) {
        transform.localScale = transform.localScale + scale;
    }

    public void UpdateColor(Color newColor) {
        gameObject.GetComponent<Renderer>().material.color = newColor;
    }

}











