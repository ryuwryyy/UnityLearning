// 名前空間:参照
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// クラス定義
public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		// first express message
		Debug.Log("[Start]");
	}
	
	// Update is called once per frame
	void Update () {
		// While push space-key, express message
		if (Input.GetKey (KeyCode.Space)) {
			Debug.Log ("[Update] Space Key pressed");
		}
	}
}
