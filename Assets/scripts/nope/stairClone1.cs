//using UnityEngine;
//using System.Collections;
//
//public class stairClone1 : MonoBehaviour {
//
//	//public GameObject prefabStairOne;
//	public Transform prefabStairOne;
//	//public float spacing = 1f;
//
//
//	// Use this for initialization
//
//	void Start() {
//		StartCoroutine (stairOne());
//		}
//
//	void Update(){
////		if (Input.GetKeyDown (KeyCode.Z)) {
//		}
//	
//	IEnumerator stairOne() {
//
//		int counter = 0;
//		//int spacing = 1;
//		int X = 0;
//		int Z = 0;
//		int Y = 0;
//
//			if (counter >  ){
//
//				Vector3 pos = new Vector3(X, 0f, Z) ;
//				Instantiate(prefabStairOne, pos, Quaternion.identity);
//				//Debug.Log(counter);
//				Z = Z + 1;
//				Y = Y + 1;
//				//counter = 0;
//				//X = X+3;
//		}
//	} 
//
//	// Update is called once per frame
//
//}


		
//using UnityEngine;
//using System.Collections;
//
//public class Bubble : MonoBehaviour {
//	
//	public float speed;
//	public Transform prefabTransform;
//	public Vector3 bubbleFirstPos;
//	public Quaternion bubbleFirstOrientation;
//	public int yBoundary;
//	public GameObject bubblePrefab;
//	// Use this for initialization
//	void Start () {
//		
//		speed = 4;
//		yBoundary = 14;
//		bubbleFirstPos = this.transform.position;
//		bubbleFirstOrientation = this.transform.rotation;
//		prefabTransform = this.transform;
//		
//	}
//	
//	// Update is called once per frame
//	void Update () {
//		
//		if ( GameObject.Find("Manager").GetComponent<Manager>( ).boolBubble == true) {
//			prefabTransform.Translate(0,Time.deltaTime * speed,0);
//		}
//		
//		// clone new bubble when it goes over yBoundary and Destroy it and repeat.
//		if (prefabTransform.position.y > yBoundary) {
//			
//			Instantiate(bubblePrefab,bubbleFirstPos,bubbleFirstOrientation);
//			Destroy(this.gameObject);
//			
//		}	
//	}
