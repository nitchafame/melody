using UnityEngine;
using System.Collections;

public class stairClone1 : MonoBehaviour {

	//public GameObject prefabStairOne;
public Transform stairOne;
//public Transform rat; 
//public Transform building; 
//public Transform trash; 
// Use this for initialization
	void Start () {
		StartCoroutine ( stepOne () );
}

//void Update () {
//	if (Input.GetKeyDown ("space")){
//		Application.LoadLevel(0);
//	}


	IEnumerator stepOne () {
	int X = 0;
	int Y = 0;
	int Z = 0;
	int counter = 0;
	
	while ( true ){

		if ( counter > 9){
			Z = 0;
			Y = Y + 1;
		 	X = X - 1;
//			counter = 0;
		}
	
		if (Input.GetKeyDown (KeyCode.Z)){
			Instantiate (stairOne, new Vector3 (X,0f,Z),Quaternion.identity);//Quaternion.identity=no rotation
			Debug.Log(counter);
			Z = Z+1;
			//X = X+3;
			counter++;
			// RangeAttribute++;
				
//		} else if (caseRandom < 6f) {
//			Instantiate (building, new Vector3 (X-3f,7f,Z-0.3f),Quaternion.identity);//Quaternion.identity=no rotation
//			Z = Z+3;
//			counter++;
//			
//		} else if (caseRandom < 9f) {
//			Instantiate (trash, new Vector3 (X-4f,-0.8f,Z+4.5f),Quaternion.Euler(0f, Random.Range(0f, 360f), 0f ));//Quaternion.identity=no rotation
//			Z = Z+3;
//			counter++;
//			
//		} else {
//			Instantiate (rat, new Vector3 (X-2f,1f,Z),Quaternion.Euler(0f, Random.Range(0f, 360f), 0f ));//Quaternion.identity=no rotation
//			Z = Z+3;
//			counter++;
//		}
//		
		yield return new WaitForSeconds(0.10f);
		}
	}
	}
}