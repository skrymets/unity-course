using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{

	static MusicPlayer _instance;

	public static MusicPlayer instance
	{
		get
		{
			if (_instance == null)
			{
				_instance = GameObject.FindObjectOfType<MusicPlayer>();
				if (_instance == null)
				{
					Debug.LogWarning("Player not found");
				}
				else {
					GameObject.DontDestroyOnLoad(_instance.gameObject);
				}
			}
			return _instance;
		}
	}


	// Use this for initialization
	void Awake()
	{
		if (_instance == null)
		{
			_instance = this;
			DontDestroyOnLoad(gameObject);
		}
		else {
			Destroy(gameObject);
		}
	}

	// Update is called once per frame
	void Update()
	{

	}
}
