using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	[SerializeField] private float _movementSpeed;
	[SerializeField] private string _horizontalAxis;

	[SerializeField] private float _bounds;

	private void Update()
	{
		MovePlayer();
	}

	private void MovePlayer()
	{
		float moveInput = Input.GetAxisRaw(_horizontalAxis);

		Vector2 playerPos = transform.position;
		playerPos.x = Mathf.Clamp(playerPos.x + moveInput * _movementSpeed * Time.deltaTime, -_bounds, _bounds);

		transform.position = playerPos;
	}
}
