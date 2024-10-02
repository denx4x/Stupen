using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public CharacterController characterController;
    public float speed = 12f;

    // Update is called once per frame
    void Update() {
        float x = Input.GetAxis("Horizontal") * speed;
        float z = Input.GetAxis("Vertical") * speed;
        Vector3 direction = transform.right * x + transform.forward * z;
        characterController.Move(direction * Time.deltaTime);
    }
}
