//using UnityEngine;
//using System.Collections;
//
//
//
//public class raycast : MonoBehaviour {
//
//	// Use this for initialization
//
//	public float speed;
//
//
//	void Start () {
//	
//	}
//	
//	// Update is called once per frame
//	void Update () {
//	
//		if(Input.GetKey(KeyCode.UpArrow))
//		{
//			Transform.position -= new Vector3(speed * Time.deltaTime,0,0);
//		}
//
//			if(Input.GetKey (KeyCode.DownArrow))
//		{
//			Transform.position += new Vector3(speed * Time.deltaTime,0,0);
//		}
//		if(Input.GetKey (KeyCode.RightArrow))
//		{
//			transform.position += new Vector3(0,0, speed * Time.deltaTime);
//		}
//		if(Input.GetKey (KeyCode.LeftArrow))
//		{
//			Transform.position -= new Vector3(0,0, speed * Time.deltaTime);
//		}
//	}
//}
