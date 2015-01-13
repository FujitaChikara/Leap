using UnityEngine;
using System.Collections;

public class SphereDischarge : MonoBehaviour {
    public GameObject[] sphere;
	public GameObject[] launchPad;
    private float count=1;
	private Timer timer;
	private GameObject countDown;
	// Use this for initialization
	void Start () {
		timer = GameObject.Find ("Timer").GetComponent <Timer>();
		countDown = GameObject.Find ("CountDown");
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (countDown != null) {
			return;
		}

		if (!timer.TimerFlg()) {
			count++;
			if (count >= 30) {
				int rand = Random.Range (0, 3);
				int rand2 = Random.Range (0, sphere.Length);
				//Debug.Log(sphere.Length);
				Instantiate (sphere [rand2], launchPad [rand].transform.position, Quaternion.identity);
				count = 0;
			}
		}
    }
}
