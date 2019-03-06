using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindmillScript : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		transform.RotateAround(transform.position, transform.right, Time.deltaTime*40f);
	}
}
