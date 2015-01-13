using UnityEngine;
using System.Collections;

public class UIFlashing : MonoBehaviour {
	public UILabel label;
	Vector4 color;
	bool flg;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		color = label.color;
		if (flg) {
			color.w+=Time.deltaTime;
		} 
		else {
			color.w-=Time.deltaTime;
		}
		if(color.w<=0)
		{
			flg=true;
		}

		if (color.w >= 1) {
			flg=false;		
		}

		label.color = color;

	}
}
