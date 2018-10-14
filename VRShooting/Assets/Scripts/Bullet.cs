using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))] // 同じゲームオブジェクトに指定されたコンポーネントが指定されていることが必須に
public class Bullet : MonoBehaviour 
{
	[SerializeField] float speed = 20f;
	[SerializeField] ParticleSystem hitParticlePrefab;
	void Start()
	{
		// ゲームオブジェクト前方法の速度ベクトルを計算
		var velocity = speed * transform.forward;
		// Rigidbody コンポーネントを取得
		var rigidbody = GetComponent<Rigidbody> ();
		// Rigidbody コンポーネントを使って初速を与える
		rigidbody.AddForce (velocity, ForceMode.VelocityChange);
	}

	// トリガー領域進入時に呼び出される
	void OnTriggerEnter(Collider other)
	{
		// 衝突対象に"OnHitBullet"
		other.SendMessage("OnHitBullet");

		/// 着弾地点に演出自動再生のゲームオブジェクトを生成
		Instantiate(hitParticlePrefab, transform.position, transform.rotation);

		// 自信のゲームオブジェクトを破棄
		Destroy(gameObject);
	}
}
