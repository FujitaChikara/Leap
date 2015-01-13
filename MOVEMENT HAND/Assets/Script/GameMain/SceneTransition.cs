using UnityEngine;
using System.Collections;

public class SceneTransition : MonoBehaviour {
	public string sceneName;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			Application.LoadLevel(sceneName);
		}
	}

	void OnCollisionEnter(Collision col)
	{
		Application.LoadLevel (sceneName);
	}
}
