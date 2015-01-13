using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {
	public float timer=60.0f;
	private GameObject countDown;
	// Use this for initialization
	void Start () {
		countDown = GameObject.Find ("CountDown");
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		if (countDown != null) {
			return;
		}

		if (timer <= 0) {

			StartCoroutine(SceneChage(3.0f));
			return;		
		}

		timer -= Time.deltaTime;
		guiText.text ="Timer: "+timer.ToString ("F2");


	}

	public void AddTimer(float time)
	{
		timer += time;
	}

	public void SubTimer(float time)
	{
		timer -= time;
	}

	public bool TimerFlg()
	{
		if (timer <= 0) {
			return true;		
		}
		return false;
	}

	private IEnumerator SceneChage(float time)
	{
		yield return new WaitForSeconds (time);
		Application.LoadLevel ("Ranking");
		Debug.Log ("yeld");
	}
}
