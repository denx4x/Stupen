using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeManager : MonoBehaviour {

    private GameObject redBox;
    private GameObject greenBox;
    private GameObject blueBox;

    private GameObject[] greenBoxes;

    // Start is called before the first frame update
    void Start() {
        
        redBox = GameObject.Find("Red");
        redBox = GameObject.FindGameObjectWithTag("Red");
        greenBox = GameObject.FindGameObjectWithTag("Green");
        blueBox = GameObject.FindGameObjectWithTag("Blue");

        greenBoxes = GameObject.FindGameObjectsWithTag("Green");

        SetTeam();

    }

    void SetTeam() {
        redBox.GetComponent<CubeController>().ActivateCube(Color.red);
        greenBox.GetComponent<CubeController>().ActivateCube(Color.green);
        blueBox.GetComponent<CubeController>().ActivateCube(Color.blue);
    }

}
