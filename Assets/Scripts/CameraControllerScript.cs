using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControllerScript : MonoBehaviour {

    private Transform player;
    // Start is called before the first frame update
    void Start() {
    }
    
    public void findPlayer() {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update() {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        transform.position = player.position;
    }
}
