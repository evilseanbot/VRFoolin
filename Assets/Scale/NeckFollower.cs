using UnityEngine;
using System.Collections;

public class NeckFollower : MonoBehaviour {

	public Transform target = null;

	public Transform hips;
	public Transform spine;
	public Transform spine1;
	public Transform spine2;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {



		float opposite = target.position.x;
		float adj = 8f;
		float tanC = opposite / adj;
		float angle = Mathf.Atan (tanC);
		//Debug.Log (angle);
		float rotationZ = angle*60f / 4;

		opposite = target.position.z+5;
		adj = 8f;
		tanC = opposite / adj;
		angle = Mathf.Atan (tanC);
		float rotationX = angle * 60f / 4;

		hips.transform.localEulerAngles = new Vector3 (rotationX, 0, -rotationZ);
		spine.transform.localEulerAngles = new Vector3 (rotationX, 0, -rotationZ);
		spine1.transform.localEulerAngles = new Vector3 (rotationX, 0, -rotationZ);
		spine2.transform.localEulerAngles = new Vector3 (rotationX, 0, -rotationZ);

		//Quaternion newRotation = Quaternion.Euler (0, 0, 45);

		//transform.rotation.Set (newRotation.x, newRotation.y, newRotation.z, newRotation.w);
	}
}
