using UnityEngine;
using System.Collections;

public class Bomb : MonoBehaviour {
	private Timer timer;
	public GameObject addTimer;
	public GameObject particl;
	bool flg;
	// Use this for initialization
	void Start () {
		timer = GameObject.Find("Timer").GetComponent<Timer> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (flg) {
			Destroy (gameObject);
			addTimer.guiText.text="-5";
			Instantiate(particl,gameObject.transform.position,Quaternion.identity);
			Instantiate(addTimer);
			timer.SubTimer (5.0f);
		}
	}

	void OnCollisionExit(Collision col)
	{
		flg = true;

	}
}
