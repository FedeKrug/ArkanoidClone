using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerBySlider : MonoBehaviour
{
	[SerializeField] private Transform _slider;
	[SerializeField] private float _distanceModifier;
	//[SerializeField] Transform _playerPos;

	private void Update()
	{
		transform.position = new Vector3(_slider.position.x * _distanceModifier, transform.position.y, transform.position.z) ;
	}
}
