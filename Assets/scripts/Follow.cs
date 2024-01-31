using UnityEngine;

public class Follow : MonoBehaviour
{
	public Transform player; // Assign the player's transform in the inspector
	public Vector3 offset = new Vector3(0, 2, 0); // Adjust this offset to position the text above the player's head
	public Transform mainCamera; // Assign the main camera in the inspector

	void Update()
	{
		// Position the text above the player with the given offset
		transform.position = player.position + offset;

		// Rotate the text to face the camera along the Y axis
		Vector3 targetPosition = new Vector3(mainCamera.transform.position.x, transform.position.y, mainCamera.transform.position.z);
		transform.LookAt(targetPosition);

		// Optional: Adjust the text to always be upright relative to the camera
		transform.rotation = Quaternion.Euler(0, transform.rotation.eulerAngles.y, 0);
	}
}
