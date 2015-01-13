using UnityEngine;
using System.Collections;

public class AfterScore : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		int a =PlayerPrefs.GetInt ("NowScore");
		guiText.text = "Score  "+ a.ToString();
	}
}
