using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmitParticlesOnAudio : MonoBehaviour {
	ParticleSystem particleSystem;
	AudioSource audioSource;
	void Start () {
		audioSource = GetComponent<AudioSource>();
		particleSystem = GetComponent<ParticleSystem>();
		InvokeRepeating("EmitParticlesIfPlaying", 0.0f, 0.1f);
	}

	// void Update() {
	// 	if (audioSource.isPlaying && !particleSystem.isEmitting) {
	// 		particleSystem.Play();
	// 	} else if (!audioSource.isPlaying && particleSystem.isEmitting) {
	// 		particleSystem.Stop();
	// 	}
	// } 

	void EmitParticlesIfPlaying() {
		if (audioSource.isPlaying) {
			particleSystem.Emit(1);
		}
	}
}
