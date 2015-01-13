using UnityEngine;
using System.Collections;

public class SphereMove : MonoBehaviour {
	private float[] addForceY=new float[]{605,575,590};
	public GameObject particle;
	// Use this for initialization
	void Start () {
		int rand = Random.Range (0,3);
		rigidbody.AddForce (0,addForceY[rand],-600);
		Instantiate (particle,gameObject.transform.position,Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
   
	}

    void OnCollisionEnter(Collision collision)
    {
        
        
		collider.isTrigger = true;
		audio.Play ();
        
    }

    
    void OnTriggerEnter(Collider other)
    {
        
		if (other.gameObject.tag == "kabe")
		{
			Destroy(gameObject);
		}
	}
	
	
	
}
