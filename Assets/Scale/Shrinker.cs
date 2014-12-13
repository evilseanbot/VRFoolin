using UnityEngine;
using System.Collections;

public class Shrinker : MonoBehaviour {

	public Transform world;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		double scaleDim = transform.localScale.x;
		//Vector3 currentScale = new Vector3 (scaleDim, scaleDim, scaleDim);
		//double scaleChange = scaleDim * 0.01;
		//float scaleChange

		// Shrink world to proper size.
		if (scaleDim < 0.001 && world.localScale.x == 100) {
			world.localScale = new Vector3(100000, 100000, 100000);
		}
		if (scaleDim < 1 && world.localScale.x == 0.1f) {
			world.localScale = new Vector3(100, 100, 100);
		}
		if (scaleDim < 1000 && world.localScale.x == 0.0001f) {
			world.localScale = new Vector3(0.1f, 0.1f, 0.1f);
		}
		if (scaleDim < 1000000 && world.localScale.x == 0.0000001f) {
			world.localScale = new Vector3(0.0001f, 0.0001f, 0.0001f);
		}

		// Grow world to proper size.
		if (scaleDim > 0.001 && world.localScale.x == 100000) {
			world.localScale = new Vector3(100, 100, 100);
		}
		if (scaleDim > 1 && world.localScale.x == 100) {
			world.localScale = new Vector3(0.1f, 0.1f, 0.1f);
		}
		if (scaleDim > 1000 && world.localScale.x == 0.1f) {
			world.localScale = new Vector3(0.0001f, 0.0001f, 0.0001f);
		}
		if (scaleDim > 1000000 && world.localScale.x == 0.0001f) {
			world.localScale = new Vector3(0.0000001f, 0.0000001f, 0.0000001f);
		}

		if (Input.GetKey("down")) {
			//if (scaleDim > 1) {
				double scaleChange = scaleDim * 0.99;
				float scaleChangeF = (float)scaleChange;
				transform.localScale = new Vector3(scaleChangeF, scaleChangeF, scaleChangeF); 
			//}
		}

		if (Input.GetKey("up")) {
				double scaleChange = scaleDim * 1.01;
				float scaleChangeF = (float)scaleChange;
				transform.localScale = new Vector3(scaleChangeF, scaleChangeF, scaleChangeF); 
		}


	}
}
