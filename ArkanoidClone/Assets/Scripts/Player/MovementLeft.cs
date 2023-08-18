
using UnityEngine;

public class MovementLeft : PlayerMovement
{
	private void Update()
	{
		Move();
	}



	public void Move() //1 (right) || -1 (left)
	{
		if (!_isMoving) return;
		Vector2 playerPos = transform.position;

		playerPos.x = Mathf.Clamp(playerPos.x - 1/*direction*/ * _movementSpeed * Time.deltaTime, -_bounds, _bounds);
		transform.position = playerPos;
	}

	public void OnInputDown()
	{
		_isMoving = true;
	}

	public void OnInputUp()
	{
		_isMoving = false;

	}

}