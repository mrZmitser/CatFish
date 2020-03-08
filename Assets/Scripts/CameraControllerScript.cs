using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControllerScript : MonoBehaviour {

    private GameObject player;
    public float smooth = 5.0f;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start() {
        player = GameObject.FindGameObjectWithTag("Player");
        offset = transform.position - player.transform.position;
    }


    void Update() {
        transform.position = Vector3.Lerp(transform.position, player.transform.position + offset, Time.deltaTime * smooth);
    }
}
