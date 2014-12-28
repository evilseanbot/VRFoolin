﻿using UnityEngine;
using System.Collections;

public class Shrinker : MonoBehaviour {

	public Transform world;
	public GameObject selectiveVisibility;

	public Material nightSky;
	public Material daySky;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		double scaleDim = transform.localScale.x;

		adjustWorldScale (scaleDim);

		if (Input.GetKey("down")) {
				double scaleChange = scaleDim * (1f - (1f * Time.deltaTime));
				float scaleChangeF = (float)scaleChange;
				transform.localScale = new Vector3(scaleChangeF, scaleChangeF, scaleChangeF); 
		}

		if (Input.GetKey("up")) {
				double scaleChange = scaleDim * (1f + (1f * Time.deltaTime));
				float scaleChangeF = (float)scaleChange;
				transform.localScale = new Vector3(scaleChangeF, scaleChangeF, scaleChangeF); 
		}


	}

	void adjustWorldScale(double playerScale) {

		bool scaleChanged = false;
		float newScale;

		// Shrink world to proper size.
		for (int i = -1; i < 8; i++) {
			if (playerScale < Mathf.Pow (10, i*3) && world.localScale.x == (float)(Mathf.Pow (10, -(i+1)*3) * 100f)) {
				newScale = Mathf.Pow (10, -((i)*3)) * 100f;
				world.localScale = new Vector3(newScale, newScale, newScale);
				scaleChanged = true;
			}


			if (playerScale > Mathf.Pow (10, i*3) && world.localScale.x == (float)(Mathf.Pow (10, -((i)*3)) * 100f)) {
				newScale = Mathf.Pow (10, -((i+1)*3)) * 100f;
				world.localScale = new Vector3(newScale, newScale, newScale);
				scaleChanged = true;
			}
		}
		/*if (playerScale < 0.001 && world.localScale.x == 100) {
			world.localScale = new Vector3(100000, 100000, 100000);
			scaleChanged = true;
		}
		if (playerScale < 1 && world.localScale.x == 0.1f) {
			world.localScale = new Vector3(100, 100, 100);
			scaleChanged = true;
		}
		if (playerScale < 1000 && world.localScale.x == 0.0001f) {
			world.localScale = new Vector3(0.1f, 0.1f, 0.1f);
			scaleChanged = true;
		}
		if (playerScale < 1000000 && world.localScale.x == 0.0000001f) {
			world.localScale = new Vector3(0.0001f, 0.0001f, 0.0001f);
			scaleChanged = true;
		}
		if (playerScale < 1000000000 && world.localScale.x == 0.0000000001f) {
			world.localScale = new Vector3(0.0000001f, 0.0000001f, 0.0000001f);
			scaleChanged = true;
		}
		if (playerScale < 1000000000000 && world.localScale.x == 0.0000000000001f) {
			world.localScale = new Vector3(0.0000000001f, 0.0000000001f, 0.0000000001f);
			scaleChanged = true;
		}
		if (playerScale < 1000000000000000 && world.localScale.x == 0.0000000000000001f) {
			world.localScale = new Vector3(0.0000000000001f, 0.0000000000001f, 0.0000000000001f);
			scaleChanged = true;
		}
		
		// Grow world to proper size.
		if (playerScale > 0.001 && world.localScale.x == 100000) {
			world.localScale = new Vector3(100, 100, 100);
			scaleChanged = true;
		}
		if (playerScale > 1 && world.localScale.x == 100) {
			world.localScale = new Vector3(0.1f, 0.1f, 0.1f);
			scaleChanged = true;
		}
		if (playerScale > 1000 && world.localScale.x == 0.1f) {
			world.localScale = new Vector3(0.0001f, 0.0001f, 0.0001f);
			scaleChanged = true;
		}
		if (playerScale > 1000000 && world.localScale.x == 0.0001f) {
			world.localScale = new Vector3(0.0000001f, 0.0000001f, 0.0000001f);
			scaleChanged = true;
		}
		if (playerScale > 1000000000 && world.localScale.x == 0.0000001f) {
			world.localScale = new Vector3(0.0000000001f, 0.0000000001f, 0.0000000001f);
			scaleChanged = true;
		}
		if (playerScale > 1000000000000 && world.localScale.x == 0.0000000001f) {
			world.localScale = new Vector3(0.0000000000001f, 0.0000000000001f, 0.0000000000001f);
			scaleChanged = true;
		}
		if (playerScale > 1000000000000000 && world.localScale.x == 0.0000000000001f) {
			world.localScale = new Vector3(0.0000000000000001f, 0.0000000000000001f, 0.0000000000000001f);
			scaleChanged = true;
		}
		*/

		// Adjust atmosphere
		if (playerScale > 10000000) {
			RenderSettings.skybox = nightSky;
		}
		
		if (playerScale < 10000000) {
			RenderSettings.skybox = daySky;
		}

		if (scaleChanged) {
			selectiveVisibility.GetComponent<SelectiveVisibility>().scaleChange(world.localScale.x, playerScale);
		}
	}
}
