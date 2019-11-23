using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bloodbar : MonoBehaviour {
	public GameObject character;
	

	void Start () {
		

	void Update () {
		
		gameObject.transform.position = new Vector3(character.transform.position.x, character.transform.position.y + 2, character.transform.position.z);
	}
}
