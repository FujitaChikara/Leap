using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ScoreSave : MonoBehaviour {
	bool saveflag;
	Score score;
	Timer timer;
	public GameObject ngui;
	// Use this for initialization
	void Start () {
		score = GameObject.Find ("Score").GetComponent<Score> ();
		timer = GameObject.Find ("Timer").GetComponent<Timer> ();
		saveflag=false;
		
		if( !PlayerPrefs.HasKey( "SaveData" ) )
		{
			List< int > list = new List<int>( 5 );
			list.Add ( 50 );
			list.Add ( 10 );
			list.Add ( 40 );
			list.Add ( 30 );
			list.Add ( 20 );
			

			Save ( list.ToArray() );
		}
	}
	
	// Update is called once per frame
	void Update () {

		if (timer.TimerFlg ())
		{

			if (!saveflag) 
			{

				List< int > list = new List<int> ();


				string data = PlayerPrefs.GetString ("SaveData");
				string[] values = data.Split (',');

				for (int i=0; i<values.Length; i++)
				{
					list.Add (int.Parse (values [i]));
				}


				list.Add (score.nowScore ());
				list.Sort (Compare);
				PlayerPrefs.SetInt("NowScore",score.nowScore());
				Save (list.ToArray ());
				saveflag = true;
				Instantiate(ngui);
			
			}
		}
	}
	void Save( int[] data )
	{
		System.Text.StringBuilder sb=new System.Text.StringBuilder();
		
		for(int i=0;i<data.Length;i++)
		{
			sb.Append(data[i].ToString());
			if( i < (data.Length-1) ) {
				sb.Append( "," );
			} 
			
		}
		PlayerPrefs.SetString("SaveData",sb.ToString());
	}
	
	int Compare( int l, int r )
	{
		return r - l;
	}
}
