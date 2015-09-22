using UnityEngine;
using System.Collections;

public class ComponentCache  
{
	private readonly GameObject GameObject;
	
	public Renderer Renderer 
	{ 
		get 
		{ 
			if (_renderer == null)
			{
				_renderer = GameObject.GetComponent<Renderer>();
			}
			return _renderer; 
		}
	}
	private Renderer _renderer;
	
	public Material Material 
	{ 
		get 
		{ 
			if (_material == null)
			{
				_material = Renderer.material;
			}
			return _material; 
		}
	}
	private Material _material;	
	
	public BoxCollider BoxCollider 
	{ 
		get 
		{ 
			if (_boxCollider == null)
			{
				_boxCollider = GameObject.GetComponent<BoxCollider>();
			}
			return _boxCollider; 
		}
	}
	private BoxCollider _boxCollider;
	
	public Camera Camera 
	{ 
		get 
		{ 
			if (_camera == null)
			{
				_camera = GameObject.GetComponent<Camera>();
			}
			return _camera; 
		}
	}
	private Camera _camera;	
	
	public RectTransform RectTransform 
	{ 
		get 
		{ 
			if (_rectTransform == null)
			{
				_rectTransform = GameObject.GetComponent<RectTransform>();
			}
			return _rectTransform; 
		}
	}
	private RectTransform _rectTransform;			

	public ComponentCache(GameObject sourceGameobject)
	{
		GameObject = sourceGameobject;
	}
}
