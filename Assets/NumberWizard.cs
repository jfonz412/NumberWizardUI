﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {
	int max;
	int min;
	int guess;
	public int maxGuessesAllowed;
	
	public Text text;
	
	// Use this for initialization
	void Start () {
		StartGame();
	}
	
	void StartGame()
	{
		max = 1000;
		min = 1;
		NextGuess();
	}
	
	public void GuessHigher()
	{
		min = guess;
		NextGuess();
	}
	
	public void GuessLower()
	{
		max = guess;
		NextGuess();
	}
	
	void NextGuess(){
		//guess = (max + min) / 2; //halfway between the max and the min
		guess = Random.Range(min, max + 1);
		text.text = guess.ToString();
		maxGuessesAllowed = maxGuessesAllowed - 1;
		if(maxGuessesAllowed <= 0)
		{
			Application.LoadLevel("Win");
		}
	}
}
