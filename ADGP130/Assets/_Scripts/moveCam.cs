using UnityEngine;
using System.Collections;

public class moveCam : MonoBehaviour {

    public GameObject testSphere;
    private Vector3 offset;

	// Use this for initialization
	void Start () {
        offset = transform.position - testSphere.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
        transform.position = testSphere.transform.position + offset;
	}
}