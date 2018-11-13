using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    private Player player;
    private Vector3 offset;

    // Use this for initialization
    void Start () {
        player = GameObject.FindObjectOfType<Player>();
        offset = this.transform.position - player.transform.position;
    }
	
	// Update is called once per frame
	void Update () {

        transform.position = player.transform.position + offset;
	}
}
