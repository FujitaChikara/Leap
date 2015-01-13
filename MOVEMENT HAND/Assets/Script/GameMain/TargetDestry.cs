using UnityEngine;
using System.Collections;

public class TargetDestry : MonoBehaviour {
	public Timer timer;
	public Score score;
	public GameObject addTimer;
	public GameObject particl;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionExit(Collision col)
	{
		score.AddScore ();
		audio.Play ();
		Vector3 pos = col.transform.position;


		Instantiate (particl,pos,Quaternion.identity);
		col.gameObject.collider.isTrigger = true;
		if (col.gameObject.tag == gameObject.tag) {
			
			addTimer.guiText.text="+5";
			Instantiate (addTimer);
			timer.AddTimer(5.0f);
			return;
		}
		

	}

	void OnTriggerEnter(Collider col)
	{

	}
}
