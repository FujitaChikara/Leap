using UnityEngine;
using System.Collections;

public class SceneChenge : MonoBehaviour {
	float count=0;
	bool flg;
	public UISprite sp;
	public string sceneName;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//UISprite sp = GetComponent<UISprite>();
		if (flg) {
			count +=0.25f* Time.deltaTime;
			sp.fillAmount=count;
			if (count > 1) {
				Application.LoadLevel (sceneName);
				
			}	
		}
		else {
			count=0;
		}
	}

	void OnTriggerEnter(Collider col)
	{
		flg = true;
	}

	void OnTriggerExit(Collider col)
	{
		flg = false;
		count = 0;
		sp.fillAmount=count;
	}
}
