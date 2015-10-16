using UnityEngine;
using System.Collections;

public class Seb_PlayerController : MonoBehaviour {

	public Rigidbody rb;
	public float speed = 1000;
	public Vector3 movement;
	public Vector3 lookingAt = new Vector3(1,2,3);
	public Quaternion quadd;

	void Start () {
		rb = GetComponent<Rigidbody>();
		rb.AddRelativeTorque(new Vector3 (20.0f, 1.0f, 2.5f));
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// before calculating physics
	void FixedUpdate () {


		//quadd = // new Quaternion (1, 2, 3, 4);
		quadd = Quaternion.LookRotation(lookingAt);
//		Quaternion.l


		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		movement = new Vector3 (moveVertical , moveHorizontal, 0.0f);

		//rb.AddForce (movement * speed * Time.deltaTime);
		rb.AddRelativeTorque(movement * speed * Time.deltaTime);

	}
}