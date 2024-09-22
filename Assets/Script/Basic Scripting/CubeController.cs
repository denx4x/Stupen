using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour {

    private CubeBehaviour cubeBehaviour;

    private void Awake() {
        
        // GetComponent berfungsi untuk menambahkan component ke dalam object
        cubeBehaviour = gameObject.AddComponent<CubeBehaviour>();

    }

    void Start() {

        //ActivateCube();

    }

    public void ActivateCube(Color teamColor) {

        cubeBehaviour.UpdateColor(teamColor);
        cubeBehaviour.UpdatePosition(new Vector3(1, 1, 1));

    }


}
