using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputControlDemo : MonoBehaviour {

    [SerializeField]
    private Transform _cubeTransform;
    [SerializeField]
    private MeshRenderer _cubeMeshRenderer;


    // Start is called before the first frame update
    void Start() {
        
        _cubeTransform.position = new Vector3(3,4,1);
        _cubeTransform.localEulerAngles = new Vector3 (30,10,90);
        _cubeTransform.localScale = new Vector3(2,1,2);

        _cubeMeshRenderer.material.color = Color.blue;

    }

    // Update is called once per frame
    void Update() {

        var mousePos = Input.mousePosition;
        Debug.Log("mousePos");

        /*var isPress = Input.GetKey(KeyCode.R);

        if (isPress) {
            Debug.Log("Is Press");
        }

        if (Input.GetKeyDown(KeyCode.E)) {
            Debug.Log("Get Key Down");
        }

        if (Input.GetKeyUp(KeyCode.E)) {
            Debug.Log("Get Key Up");
        }

        if (Input.GetButtonDown("Pukul")) {
            Debug.Log("This Is Input Mapping = Pukul");
        }*/

    }
}
