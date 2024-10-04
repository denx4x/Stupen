using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour {

    public GameObject pipePrefab;
    public float spawnDelay = 1.5f;
    public float pipeMinY = -2f;
    public float pipeMaxY = 2f;

    void Start() {
        InvokeRepeating(nameof(SpawnPipe), 0f, spawnDelay);
    }

    private void SpawnPipe() {

        var pipeY = Random.Range(pipeMinY, pipeMaxY);


        var position = new Vector3(transform.position.x, pipeY, transform.position.z);


        Instantiate(pipePrefab, position, Quaternion.identity);
    }

}
