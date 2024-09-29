using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipController : MonoBehaviour {

    [SerializeField]
    private Transform _spaceTransform;

    [SerializeField]
    private Transform _hiddenWeapon;

    [SerializeField]
    private Material _material;

    [SerializeField]
    private float moveSpeed;

    [SerializeField]
    private float _rotationSpeed;

    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        
        var horizontalInput = Input.GetAxis("Horizontal");
        var verticalInput = Input.GetAxis("Vertical");

        _spaceTransform.Translate(new Vector3(horizontalInput, 0, verticalInput) * moveSpeed * Time.deltaTime);

        if (Input.GetMouseButton(0)) {
            var mouseX = Input.GetAxis("Mouse X");
            var mouseY = Input.GetAxis("Mouse Y");

            var rot = new Vector3 (mouseY, mouseX, 0);
            _spaceTransform.localEulerAngles = _spaceTransform.localEulerAngles + rot * _rotationSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.E)) {
            _hiddenWeapon.localScale = Vector3.one;

        } else {
            _hiddenWeapon.localScale = Vector3.zero;
        }

        if(Input.GetKey(KeyCode.Q)) {
            _material.color = Color.red;
        
        } else {
            _material.color = Color.white;
        }


    }
}
