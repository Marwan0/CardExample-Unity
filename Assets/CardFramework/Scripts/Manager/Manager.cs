using UnityEngine;
using System.Collections;

public class Manager<T> : MonoBehaviour where T : MonoBehaviour
{
	static public T SharedManager
	{
		get
		{
			return MonoBehaviourUtility.GetManager<T>(ref _sharedManager);
		}
	}
	static private T _sharedManager;
}