using UnityEngine;
using System.Collections;

public class stairManager : MonoBehaviour {
		public Transform prefabStairOne;
		public Transform prefabStairTwo;
	public Transform prefabStairThree;
		int X;
		int Y ;
		int counter;
		int counterX;
		int flight;
		// Use this for initialization
		void Start () {
			X = 1;
			Y = 1;
			counter = 0;
			counterX = 0;
			flight = 5;
		}
		
		// Update is called once per frame
		void Update () {
			
		
		if (Input.GetKeyUp (KeyCode.A)) {
			if ( counterX <=flight)
				X = counterX;
			else 
				X = flight + (flight-counterX);
			
			Instantiate (prefabStairOne, new Vector3(X, counter, 0), Quaternion.identity);
			
			counterX++;	
			counter++;
		}
		if (Input.GetKeyUp (KeyCode.B)) {
			if ( counterX <=flight)
				X = counterX;
			else 
				X = flight + (flight-counterX);
			
			Instantiate (prefabStairTwo, new Vector3(X, counter, 0), Quaternion.identity);
			
			counterX++;	
			counter++;
		}
		if (Input.GetKeyUp (KeyCode.C)) {
			if ( counterX <=flight)
				X = counterX;
			else 
				X = flight + (flight-counterX);
			
			Instantiate (prefabStairThree, new Vector3(X, counter, 0), Quaternion.identity);
			
			counterX++;	
			counter++;
		}
//
//
//			else if (Input.GetKeyUp (KeyCode.B)) {
//				if ( counterX<=10)
//					Instantiate (prefabStairTwo, new Vector3(X*counterX, Y*counter, 0), Quaternion.identity);
//				else
//					Instantiate (prefabStairTwo, new Vector3(10 + (10-X*counterX), Y*counter, 0), Quaternion.identity);
//				counterX++;	
//				counter++;
//			}
//
//
//			else if (Input.GetKeyUp (KeyCode.C)) {
//				if ( counterX<=10)
//					Instantiate (prefabStairThree, new Vector3(X*counterX, Y*counter, 0), Quaternion.identity);
//				else 
//					Instantiate (prefabStairThree, new Vector3(10 + (10-X*counterX), Y*counter, 0), Quaternion.identity);
//				counterX++;	
//				counter++;
//			}




		if (counterX >= flight*2 )
				counterX = 0;



		}
	}