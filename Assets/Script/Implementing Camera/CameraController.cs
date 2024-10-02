using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public Camera mainCamera;
    public Camera secondCamera;
    private Camera activeCamera;
    public GameObject Player;

    // Start is called before the first frame update
    void Start() {
        activeCamera = mainCamera;
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown("1")) {
            mainCamera.gameObject.SetActive(true);
            secondCamera.gameObject.SetActive(true);
            activeCamera = mainCamera;
        }

        else if (Input.GetKeyDown("2")) {
            mainCamera.gameObject.SetActive(true);
            secondCamera.gameObject.SetActive(true);
            activeCamera = secondCamera;
        }

        if (Player.gameObject != null) {
            activeCamera.transform.LookAt(Player.transform);
        }

    }
}
