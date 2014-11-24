using UnityEngine;
using System.Collections;

public class Shrinker : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		double scaleDim = transform.localScale.x;
		//Vector3 currentScale = new Vector3 (scaleDim, scaleDim, scaleDim);
		//double scaleChange = scaleDim * 0.01;
		//float scaleChange

		if (Input.GetKey("down")) {
			double scaleChange = scaleDim * 0.99;
			float scaleChangeF = (float)scaleChange;
			transform.localScale = new Vector3(scaleChangeF, scaleChangeF, scaleChangeF); 
		}

		if (Input.GetKey("up")) {
			double scaleChange = scaleDim * 1.01;
			float scaleChangeF = (float)scaleChange;
			transform.localScale = new Vector3(scaleChangeF, scaleChangeF, scaleChangeF); 
		}


	}
}
