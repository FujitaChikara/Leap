using UnityEngine;
using System.Collections;

public class ControllerDelete : MonoBehaviour {
	private Timer timer;
	private GameObject hand;
	public GameObject handCL;
	// Use this for initialization
	void Start () {
		timer=GameObject.Find("Timer").GetComponent<Timer>();
		handCL = GameObject.Find ("ControllerSandBox");

	}
	
	// Update is called once per frame
	void Update () {
		if (timer.TimerFlg()) {
			hand = GameObject.Find ("SkeletalHand 1(Clone)");
			Destroy(hand);	
			Destroy(handCL);
		}
	}
}
