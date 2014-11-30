using UnityEngine;
using System.Collections;

public class MoveLeft : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.right * -0.1f);
		//transform.position.Set(transform.position.x-0.01f, transform.position.y, transform.position.z);
	}
}
