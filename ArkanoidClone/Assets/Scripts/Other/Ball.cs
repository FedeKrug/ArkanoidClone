using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Ball : MonoBehaviour
{
	[SerializeField] private Vector2 _initialSpeed;
	[SerializeField] private Rigidbody2D _rb2d;
	private bool _alreadyLaunched;


	private void Update()
	{
		if (Input.GetMouseButtonDown(0) && !_alreadyLaunched)
		{
			transform.parent = null;
			_rb2d.velocity = _initialSpeed;
			_alreadyLaunched = true;
		}
	}

}
