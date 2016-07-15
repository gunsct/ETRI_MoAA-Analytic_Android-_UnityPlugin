using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CubeSpawn : MonoBehaviour {
	string type,stack,output;
	public GameObject cube;
	// Use this for initialization
	void Start () {
		StartCoroutine ("Spawn");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator Spawn(){
		yield return new WaitForSeconds(2.0f);
		Instantiate (cube, this.transform.position, Quaternion.identity);

		StartCoroutine ("Spawn");
	}
}
