using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class Block : MonoBehaviour
{
	[SerializeField] private int _blockLife = 1;
	[SerializeField] private BlockColor _blockColor;

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.CompareTag("Player"))
		{
			_blockLife--;
			CheckDeathBlock();
		}
	}

	private void CheckDeathBlock()
	{
		if (_blockLife<=0)
		{
			Destroy(gameObject);
		}
	}


}
