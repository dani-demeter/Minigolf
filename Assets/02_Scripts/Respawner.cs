using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawner : MonoBehaviour {
	public GameObject ballPrefab;
	public Transform originalPosition;
	public void OnTriggerExit(Collider c){
		if(c.transform.root.tag=="Ball"){
			GameObject b = Instantiate(ballPrefab) as GameObject;
			b.transform.position = originalPosition.position;
		}
	}
}
