using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

	[SerializeField]
	float speed = 0.2f;
	[SerializeField]
	float HitCount = 1;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(new Vector3 (Input.GetAxis ("Horizontal") * speed,0)); 
		                                  //Input.GetAxis ("Vertical"), 0));
	}

	void OnCollisionEnter(Collision other){
		if (other.gameObject.tag == "Boll") {
			Destroy(other.gameObject);
			HitCount++;
		}
		Debug.Log ("Hit Ball " + HitCount);
	}
}
