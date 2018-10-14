using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour {
	[SerializeField] float spawnInterval = 1f; //的出現間隔

	EnemySpawner[] spawners; // EnemySpawnerのリスト
	float timer = 0f; // 出現時間判定用のタイマー変数

	// Use this for initialization
	void Start () {
		//子オブジェクトに存在するEnemySpawnerのリストを取得
		spawners = GetComponentsInChildren<EnemySpawner>();
	}
	
	// Update is called once per frame
	void Update () {
		// update timer
		timer += Time.deltaTime;

		// 出現時間の判定
		if (spawnInterval < timer) {
			// random 
			var index = Random.Range(0, spawners.Length);
			spawners [index].Spawn ();

			// reset timer
			timer = 0f;
		}
	}
}
