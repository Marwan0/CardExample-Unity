using UnityEngine;
using System.Collections;

public class ScrollTexture : MonoBehaviourBase
{	
	[SerializeField]
	private Vector2 _scrollRate;

	private Vector2 _offset;
	
	private void Update () 
	{
		_offset += Time.deltaTime * _scrollRate;
		ComponentCache.Material.SetTextureOffset("_MainTex", _offset);
	}
}
