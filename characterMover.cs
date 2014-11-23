using UnityEngine;
using System.Collections;



public class characterMover : MonoBehaviour {

	public float speed=1f;
	//Checking GIT
	void Update() 
	{
		transform.Translate(Vector3.forward * speed * Time.deltaTime*speed);
	}
}