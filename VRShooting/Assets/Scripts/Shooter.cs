using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour {

	[SerializeField] GameObject bulletPrefab;
	[SerializeField] Transform gunBarrelEnd; // 銃口

	[SerializeField] ParticleSystem gunParticle; //演出
	[SerializeField] AudioSource gunAudioSource; //音源

	// Update is called once per frame
	void Update () 
	{
		if (Input.GetButtonDown("Fire1")) 
		{
			Shoot();
		}
	}

	void Shoot()
	{
		Instantiate (bulletPrefab, gunBarrelEnd.position, gunBarrelEnd.rotation);

		// play
		gunParticle.Play();

		//music
		gunAudioSource.Play();
	}
}
