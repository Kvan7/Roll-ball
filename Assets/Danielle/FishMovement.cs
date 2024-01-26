using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishMovement : MonoBehaviour
{
	public float speed = 5.0f;
	private float zMax = 7.5f;
	private float zMin = -7.5f;
	private int direction = 1;

	private float startX = 0f;
	private float startZ = 0f;

	// Start is called before the first frame update
	void Start()
	{
		startX = transform.position.x;
		startZ = transform.position.z;

		if(startZ > 0)
        {
			transform.Rotate(new Vector3(0, 180, 0));
        }
	}

	// Update is called once per frame
	void Update()
	{
		float zNew = transform.position.z + direction * speed * Time.deltaTime;
		if (zNew >= zMax)
		{
			zNew = zMax;
			direction *= -1;

			transform.Rotate(new Vector3(0, 180, 0));
		}
		else if (zNew <= zMin)
		{
			zNew = zMin;
			direction *= -1;

			transform.Rotate(new Vector3(0, 180, 0));
		}
		transform.position = new Vector3(startX, 0, zNew);
	}
}