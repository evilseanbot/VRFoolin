using UnityEngine;
using System.Collections;

public class NeckFollower : MonoBehaviour {

	public Transform target = null;

	public Transform hips;
	public Transform spine;
	public Transform spine1;
	public Transform spine2;
	public Transform avatar;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		followHeight ();

		float opposite = target.position.x;
		float adj = Mathf.Abs (target.position.y - hips.position.y);
		float tanC = opposite / adj;
		float angle = Mathf.Atan (tanC);
		float rotationZ = angle*60f / 4;

		float scale = avatar.lossyScale.x;
		float cameraOffset = 0.2f * scale;
		opposite = (target.position.z-cameraOffset) - hips.position.z;
		adj = Mathf.Abs(target.position.y - hips.position.y);
		tanC = opposite / adj;
		angle = Mathf.Atan (tanC);
		float rotationX = angle * 60f / 4;

		hips.transform.localEulerAngles = new Vector3 (rotationX, 0, -rotationZ);
		spine.transform.localEulerAngles = new Vector3 (rotationX, 0, -rotationZ);
		spine1.transform.localEulerAngles = new Vector3 (rotationX, 0, -rotationZ);
		spine2.transform.localEulerAngles = new Vector3 (rotationX, 0, -rotationZ);
	}

	void followHeight()
	{
		float scale = avatar.lossyScale.x;
		float cameraOffset = 0.2f * scale;
		Vector3 hipFlatPos = new Vector3 (hips.position.x, 0, hips.position.z);
		Vector3 targetFlatPos = new Vector3 (target.position.x, 0, target.position.z - cameraOffset);
		float adjacent = Vector3.Distance (hipFlatPos, targetFlatPos);
		float hypo = Vector3.Distance (hips.position, spine2.position) * 2f;

		// Pythagorean theorem.

		float opposite = Mathf.Sqrt ((hypo * hypo) - (adjacent * adjacent));

		// The opposite will become nan if the hyptoneuse is shorter than the adjacent.

		if (float.IsNaN (opposite)) {
		    opposite = 0.4f;
		}

		avatar.localPosition = new Vector3 (avatar.localPosition.x, target.localPosition.y - ((opposite/scale)) + 0.3f, avatar.localPosition.z);
	}
}
