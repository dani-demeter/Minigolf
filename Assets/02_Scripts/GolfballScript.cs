using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GolfballScript : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter(Collision c){
		Debug.Log("collided");
	// 	foreach(ContactPoint cp in c.contacts){
	// 		if(cp.otherCollider.transform.root.tag=="Player"){
	// 			Debug.Log("collided with something player");
	// 			Vector3 ocp = cp.otherCollider.transform.position;
	// 			Vector3 d = transform.position-new Vector3(ocp.x, transform.position.y, ocp.z);
	// 			Debug.Log(d);
	// 			GetComponent<Rigidbody>().AddForce(50*(d.normalized), ForceMode.Acceleration);
	// 		}
	// 	}
	}
}
