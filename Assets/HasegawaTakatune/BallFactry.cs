using UnityEngine;
using System.Collections;

public class BallFactry : MonoBehaviour {

	[SerializeField]
	GameObject Ball;

	[SerializeField]
	float position = 1;

	// Use this for initialization
	void Start () {
		StartCoroutine (Factory());
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator Factory(){
		while(true){
			Instantiate(Ball,new Vector3(Random.Range(-position,position),10,0),transform.rotation);
			yield return new WaitForSeconds(0.1f);
		}

	}
}
