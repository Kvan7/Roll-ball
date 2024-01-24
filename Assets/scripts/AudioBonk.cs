using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioBonk : MonoBehaviour
{
	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{

	}

	private void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.tag == "Wall") // Make sure your wall has the tag "Wall"
		{
			GetComponent<AudioSource>().Play();
		}
	}
}
