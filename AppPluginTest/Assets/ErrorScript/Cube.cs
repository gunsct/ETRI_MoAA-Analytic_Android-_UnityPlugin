using UnityEngine;
using System.Collections;

public class Cube : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine ("Die");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator Die(){
		yield return new WaitForSeconds (5.0f);
		Destroy (this.gameObject);
	}
}
