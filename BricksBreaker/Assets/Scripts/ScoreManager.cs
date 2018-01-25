using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

	static ScoreManager _instance;

	private int totalScore = 0;

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

	internal void Earn(int prize)
	{
		totalScore += prize;
	}

	// Update is called once per frame
	void Update()
	{

	}
}
