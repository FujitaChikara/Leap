using UnityEngine;
using System.Collections;

public class ParticlDestroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Destroy (gameObject,1.0f);
	}
}
