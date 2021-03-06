﻿using UnityEngine;
using System.Collections;

public class SelectiveVisibility : MonoBehaviour {

	public GameObject plane;
	public GameObject california;
	public GameObject house;
	public GameObject rhino;

	public GameObject moonMockMeter;
	public GameObject moonMockKilo;
	public GameObject moon;

	public GameObject sunMockMeter;
	public GameObject sunMockKilo;
	public GameObject sun;

	public GameObject solarSystem;

	public Component[] rends; 
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void scaleChange(float scale, double playerScale) {

		if (scale == 0.0000000001f) {			
			//moon.renderer.enabled = true;
			//sun.renderer.enabled = true;

			solarSystem.renderer.enabled = true;

			//moonMockKilo.renderer.enabled = false;
			//sunMockKilo.renderer.enabled = false;
		}

		Debug.Log (scale);

		if (scale < 0.0000000001f) {
			Debug.Log ("Scale is small enough");
		}

		if (scale > 0.001f) {
			Debug.Log ("Scale is big enough");
		}

		if (scale > 0.0000000001f && scale < 0.0001f) {//0.0000001f) {			
			Debug.Log ("Inside");
			solarSystem.renderer.enabled = false;

			//moon.renderer.enabled = true;
			//sun.renderer.enabled = true;

			//moonMockKilo.renderer.enabled = false;
			//sunMockKilo.renderer.enabled = false;
		}


		if (scale == 0.0001f) {			
			//moon.renderer.enabled = false;
			//sun.renderer.enabled = false;

			california.renderer.enabled = true;
			//moonMockKilo.renderer.enabled = true;
			//sunMockKilo.renderer.enabled = true;

			//moonMockMeter.renderer.enabled = false;
			//sunMockMeter.renderer.enabled = false;
			plane.renderer.enabled = false;
		}

		if (scale == 0.1f) {
			//moonMockKilo.renderer.enabled = false;
			//sunMockKilo.renderer.enabled = false;
			california.renderer.enabled = false;

			setRendering(house, true);
			setRendering(rhino, true);
			plane.renderer.enabled = true;
			//moonMockMeter.renderer.enabled = true;
			//sunMockMeter.renderer.enabled = true;
		}

		if (scale == 100f) {

			setRendering(house, false);
			setRendering(rhino, false);
		}
	}

	void setRendering(GameObject model, bool shouldRender) {
		rends = model.GetComponentsInChildren<Renderer>();

		foreach( Renderer rend in rends) {
			rend.enabled = shouldRender;
		}
	}
}
