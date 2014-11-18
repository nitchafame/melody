using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour {

//	public TextMesh textMesh;
	public float interactionDist;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);

		RaycastHit rayHit = new RaycastHit ();

		if (Physics.Raycast (ray, out rayHit, 10f)) {

		}
	}
}
