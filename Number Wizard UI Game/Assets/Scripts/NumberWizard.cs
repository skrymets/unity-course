using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NumberWizard : MonoBehaviour {

	public int guesses = 5;
	public Text guessMessage;
	public Text guessesLeft;


	public LevelManager levelManager;

	private int currentGuesses = 0;
	private int min = 0;
	private int max = 1000;

	void Start() {
		NextGuess ();
	}

	public void NextGuess() {
		guesses--;
		guessesLeft.text = "Remaining Attempts: " + guesses.ToString();
		currentGuesses = Random.Range (min, max + 1);
		guessMessage.text = currentGuesses.ToString();
	}

	public void GuessLower() {
		max = currentGuesses;
		if (guesses > 0) {
			NextGuess ();
		} else {
			levelManager.PlayerWin();
		}
	}

	public void GuessHigher() {
		min = currentGuesses;
		if (guesses > 0) {
			NextGuess ();
		} else {
			levelManager.PlayerWin();
		}
	}

	public void NumberGuessed() {
		levelManager.PlayerLose();
	}

}
