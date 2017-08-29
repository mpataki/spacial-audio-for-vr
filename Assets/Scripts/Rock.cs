using System;
using UnityEngine;

public class Rock : MonoBehaviour
{
	AudioSource audioSource;

	// Use this for initialization
	void Start ()
	{
		Debug.Log("Initializing Rock");
		
		audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter(Collider other)
	{
		Debug.Log("oof, " + other.name + "hit the rock");
		
		if (other.name != "First Person Controller")
			return;
		
		if (!audioSource.isPlaying)
			audioSource.Play();
	}
}
