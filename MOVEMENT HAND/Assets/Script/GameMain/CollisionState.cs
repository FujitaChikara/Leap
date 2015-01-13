using UnityEngine;
using System.Collections;

public class CollisionState : MonoBehaviour {
	int count;
	bool flg;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (flg&&transform.localEulerAngles.x<=359) {
			transform.Rotate (60*Time.deltaTime,0,0);


		} 
		if(transform.localEulerAngles.x>=359)
		{
			count++;
			Debug.Log(count);
		}
		if(count>=3){
			transform.eulerAngles=Vector3.zero;
			flg=false;
		}
	}
	void OnCollisionEnter(Collision col)
	{
		flg = true;
		count = 0;
	}

	void OnCollisionExit(Collision col)
	{


	}
}
