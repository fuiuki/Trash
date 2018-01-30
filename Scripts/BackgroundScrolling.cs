using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScrolling : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        Vector3 positionMove = new Vector3(transform.position.x, transform.position.y - Time.deltaTime, transform.position.z);
        transform.position = positionMove;	
	}

    private void OnBecameInvisible()
    {
        transform.position = new Vector3(transform.position.x, 14.98f, transform.position.z);
    }
}
