using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CubeSpawn : MonoBehaviour {
	string type,stack,output;
	public GameObject cube;
	// Use this for initialization
	void Start () {
		//ErrorParser.getInstance.RegisterLog ();

		StartCoroutine ("Spawn");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator Spawn(){
		yield return new WaitForSeconds(2.0f);
		Instantiate (cube, this.transform.position, Quaternion.identity);
		//ETRI_MoAA.getInstance.error (ErrorParser.getInstance.type, ErrorParser.getInstance.stack, ErrorParser.getInstance.output);
		/*try {
			Instantiate (cube, this.transform.position, Quaternion.identity);
		}
		catch {
			ETRI_MoAA.getInstance.error ();

			//GameObject.Find("PluginTest").GetComponent<PluginTest>().myObj.Call ("error", ErrorParser.getInstance.type, ErrorParser.getInstance.stack, ErrorParser.getInstance.output + " - cube");
		}*/

		StartCoroutine ("Spawn");
	}
}
