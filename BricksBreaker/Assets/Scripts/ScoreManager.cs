using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

	static ScoreManager _instance;

	public static ScoreManager instance
	{
		get
		{
			if (_instance == null)
			{
				_instance = GameObject.FindObjectOfType<ScoreManager>();
				if (_instance != null)
				{
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
