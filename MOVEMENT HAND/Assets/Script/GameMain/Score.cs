using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {
	int score=0;
	// Use this for initialization
	void Start () {
		guiText.text ="Score: "+ score.ToString ();
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void AddScore()
	{
		score += 1;
		guiText.text ="Score: "+ score.ToString ();
	}

	public int nowScore()
	{
		return score;
	}
}
