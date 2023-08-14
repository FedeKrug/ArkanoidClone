using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	[SerializeField] private float _movementSpeed;
	[SerializeField] private string _horizontalAxis;

	[SerializeField] private float _bounds;

	[SerializeField] private bool _isMoving;
	[SerializeField] private bool _isMovingRigth;



	private void Update()
	{
		if (!_isMoving) return;
		Move();
	}



	public void Move() //1 (right) || -1 (left)
	{
		int direction;

		if (!_isMovingRigth) direction = -1;

		else if (_isMovingRigth) direction = 1;

		else direction = 0;

		Vector2 playerPos = transform.position;
		playerPos.x = Mathf.Clamp(playerPos.x + direction * _movementSpeed * Time.deltaTime, -_bounds, _bounds);
		transform.position = playerPos;
		//TODO: Arreglar bug de isMovingRigth: Hay un punto muerto en el que se sueltan los botones, donde se resetea el bool de isMovingRigth
		//, lo que ocasiona que se siga moviendo a un lado cuando presionamos el otro (se sigue moviendo a la derecha cuando presionamos izq. y viceversa)
	}
	public void OnPointerDown()
	{
		_isMoving = true;
	}

	public void OnPointerUp()
	{
		_isMoving = false;
		Debug.Log("Pointer UP");

	}

	public void DefineDirection(bool movingRigth)
	{
		_isMovingRigth = movingRigth;
	}

}
