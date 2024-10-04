using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovement : MonoBehaviour {

    public float moveSpeed = 2.0f;
    public float moveSpeedUp = 1f;
    public float speedUpDelay = 2f;
    private float speedUpTime;
    private bool hasBeenSpeedUp = false;

    private void Start() {
        speedUpTime = speedUpDelay;
    }

    void Update() {
        var nextPosition = transform.position + Vector3.left * moveSpeed * Time.deltaTime;
        transform.SetPositionAndRotation(nextPosition, transform.rotation);

        if (hasBeenSpeedUp == false) {
            speedUpTime -= Time.deltaTime;
            if (speedUpTime <= 0) {
                SpeedUp();
            }
        }
    }

    private void SpeedUp() {
        moveSpeed += moveSpeed;
        hasBeenSpeedUp = true;
    }

}
