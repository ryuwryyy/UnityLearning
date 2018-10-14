using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
	[SerializeField] AudioClip spawnClip; //Apper
	[SerializeField] AudioClip hitClip; //hit

	//倒された際に無効化するためにコライダーとレンダラーを持っておく
	[SerializeField] Collider enemyCollider; //collider
	[SerializeField] Renderer enemyRenderer; //renderer

	AudioSource audioSource; //再生に使用するAudioSource
	void Start()
	{
		// AudioSourceコンポーネントを取得
		audioSource = GetComponent<AudioSource>();

		// 出現時の音を再生
		audioSource.PlayOneShot(spawnClip);
	}
	void OnHitBullet()
	{
		// 命中時再生
		audioSource.PlayOneShot(hitClip);

		// 脂肪処理
		GoDown();

		// Destroy (gameObject); 破棄すると音が出なくなるので、あとで呼び出し
	}

	void GoDown()
	{
		// 当たり判定と表示を消す
		enemyCollider.enabled = false;
		enemyRenderer.enabled = false;

		Destroy (gameObject, 1f);
	}
}
