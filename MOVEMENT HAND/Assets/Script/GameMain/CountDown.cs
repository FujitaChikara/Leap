using UnityEngine;
using System.Collections;

public class CountDown : MonoBehaviour {
	float count;
	// Use this for initialization
	void Start () {
		count = 3;
	}
	
	// Update is called once per frame
	void Update () {
		if (count <= 0) {
			Destroy(gameObject,1f);
		}
		count -= 1 * Time.deltaTime;
	}
}