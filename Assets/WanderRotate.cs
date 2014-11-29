using UnityEngine;
using System.Collections;

public class WanderRotate : MonoBehaviour {

	Transform targetTrans = null;

	// Use this for initialization
	void Start () {
		targetTrans = transform;
		//targetTrans.rotation = transform.rotation;
	}
	
	// Update is called once per frame
	void Update () {
		float randomX = Random.Range (0f, 1f) - 0.5f;
		float randomY = Random.Range (0f, 1f) - 0.5f;
		float randomZ = Random.Range (0f, 1f) - 0.5f;


		transform.Rotate(new Vector3(randomX, randomY, randomZ));
		//targetTrans.Rotate (new Vector3 (randomX, randomY, randomZ));
		//Quaternion MoveTrans = Quaternion.Lerp (transform.rotation, targetTrans.rotation, 0.10f);
		//transform.Rotate(MoveTrans.eulerAngles);
	}
}
