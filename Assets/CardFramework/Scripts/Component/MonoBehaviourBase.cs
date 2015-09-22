using UnityEngine;
using System.Collections;

public class MonoBehaviourBase : MonoBehaviour 
{
	public ComponentCache ComponentCache 
	{ 
		get 
		{ 
			if (_componentCache == null)
			{
				_componentCache = new ComponentCache(gameObject);
			}
			return _componentCache; 
		}
	}
	private ComponentCache _componentCache;
}
