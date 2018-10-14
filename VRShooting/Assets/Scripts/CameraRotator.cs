using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CameraRotator : MonoBehaviour 
{
	[SerializeField] float angularVelocity = 30f; // 回転速度
	float horizontalAngle = 0f; // 水平の回転量を保存
	float verticalAngle = 0f; // 垂直の回転量を保存
#if UNITY_EDITOR
	void Update () 
	{
		// get 入力による回転量
		var horizontalRotation = Input.GetAxis ("Horizontal") * angularVelocity * Time.deltaTime;
		var verticalRotation = -Input.GetAxis ("Vertical") * angularVelocity * Time.deltaTime;
		// 回転量を更新
		horizontalAngle += horizontalRotation;
		verticalAngle += verticalRotation;
		//垂直方向は回転しすぎないように制限
		verticalAngle = Mathf.Clamp(verticalAngle, -80f, 80f);
		// Transform コンポーネントに回転量を適用する
		transform.rotation = Quaternion.Euler(verticalAngle, horizontalAngle, 0f);
	}
#endif
}
