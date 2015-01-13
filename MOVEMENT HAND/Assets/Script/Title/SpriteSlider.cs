using UnityEngine;
using System.Collections;

public class SpriteSlider : MonoBehaviour {

	UISprite a;
	
	[SerializeField]
	public float aa
	{
		get;
		private set;
	}
	
	// Use this for initialization
	void Start () {
		aa = 1.0f;
	}
	
	// Update is called once per frame
	void Update () {
		UISprite sp = GetComponent<UISprite>();
		if(aa>=0)
		{
			aa-=0.001f;
		}
		if(Input.GetKey(KeyCode.Space)&&aa<=1)
		{
			aa+=0.005f;
		}
		sp.fillAmount = aa;
		
	}
}
