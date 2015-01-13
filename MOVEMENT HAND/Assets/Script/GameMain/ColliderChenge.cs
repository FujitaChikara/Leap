using UnityEngine;
using System.Collections;

public class ColliderChenge : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerExit(Collider col)
	{
		col.collider.isTrigger = false;
	}
}
