using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerInput : MonoBehaviour
{
	public TMP_Text countText;
	public MenuController menuController;
	private Rigidbody rb;
	// Get speed from unity
	public float speed;
	private int count;
	private float movementX;
	private float movementY;
	// Start is called before the first frame update
	void Start()
	{
		rb = GetComponent<Rigidbody>();
		count = 0;
		SetCountText();
		// menuController.SetActive(false);
	}
	void OnMove(InputValue value)
	{
		Vector2 v = value.Get<Vector2>();

		movementX = v.x;
		movementY = v.y;

	}

	// Update is called once per frame
	private void FixedUpdate()
	{
		Vector3 movement = new Vector3(movementX, 0.0f, movementY);
		rb.AddForce(movement * speed);
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("Pickup"))
		{
			other.gameObject.SetActive(false);
			count++;
			SetCountText();
		}
	}

	private void SetCountText()
	{
		countText.text = "Count: " + count.ToString();
		if (count >= 13)
		{
			menuController.WinGame();
		}
	}
}
