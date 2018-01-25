using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
	private static MusicPlayer _playerInstance;

	public static MusicPlayer playerInstance
	{
		get
		{

			if (_playerInstance == null)
			{
				_playerInstance = FindObjectOfType<MusicPlayer>();
				Debug.Log("Player: " + _playerInstance.GetInstanceID());
				DontDestroyOnLoad(_playerInstance);
			}

			return _playerInstance;
		}
	}

	void Awake()
	{
		if (_playerInstance == null)
		{
			_playerInstance = this;
		}
		else
		{
			Destroy(gameObject);
		}
	}


	public void ToggleMuteMusic()
	{
		AudioSource music = MusicPlayer.playerInstance.gameObject.GetComponent<AudioSource>();
		music.mute = !music.mute;
	}

}
