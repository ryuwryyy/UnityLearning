using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDestroy : MonoBehaviour {
	[SerializeField] float lifetime = 5f; //寿命	

	void Start () {
	// 一定時間経過後にゲームオブジェクトを破棄する
		Destroy(gameObject, lifetime);
	}
}
