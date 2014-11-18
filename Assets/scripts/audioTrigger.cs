using UnityEngine;
using System.Collections;

public class audioTrigger : MonoBehaviour {
	bool isInTrigger = false;
	public AudioClip one;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if (isInTrigger) {
				audio.PlayOneShot (one);
				isInTrigger = false;
				}
	
	}
	void OnTriggerEnter (Collider other){
				if (other.gameObject.CompareTag ("Player")) {
						isInTrigger = true;
				}

		}
}
