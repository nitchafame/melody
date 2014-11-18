using UnityEngine;
using System.Collections;

public class characterMove : MonoBehaviour {
	public Rigidbody move;
	int counter;
	int counterX;
	int direction;
	int flight;

	// Use this for initialization
	void Start () {
		counter = 0;
//		counterX = 0;
		direction = 1;
		flight = 5;
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("space")) {
//			move.AddForce (direction, 1, 0f);
			rigidbody.MovePosition(counter, counter);
			counter++;
//			transform.Translate(counter/2,counter,0f);
		}
//
//		X++
//			X +=1
//				X = X+1
//
//				X+=2
//				X = X+2
//				X *=2 
//				X = X*2

//		if (transform.position.x > flight) {
//			direction = -1;
//		
//		} else if (transform.position.x < -flight) {
//			direction = 1;		
//		}



//		if (counterX >= 12) {
//			direction = -1;
//			counterX = 0;
			//move.AddForce ((12+ (12 - X * counterX)), Y * counter, 0);
//		}
	}
}
