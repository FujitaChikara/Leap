using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Rank : MonoBehaviour {

	public int count;
	public string words;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		List< int > list = new List<int>();
		string data=PlayerPrefs.GetString("SaveData");
		string[] values =data.Split(',');
		//int v=int.Parse (values[0]);
		
		for(int i=0;i<values.Length;i++)
		{
			list.Add(int.Parse(values[i]));

		}
		guiText.text=words+list[count].ToString();
	}
}
