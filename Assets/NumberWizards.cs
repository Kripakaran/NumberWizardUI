using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class NumberWizards : MonoBehaviour {

	// Use this for initialization
	int max;
	int min;
	int guess;
	public int maxguessesallowed=5;
	
	public Text text;
	
	void Start () {
		StartGame();
	}
	
	void StartGame(){
		max=1000;
		min=1;
		NextGuess();
		max=max+1;
	}
		
	public void GuessHigher() {
		min=guess;
		NextGuess();
	}
	
	public void GuessLower() {
		max=guess;
		NextGuess();
	}
	
	void NextGuess(){
		guess=Random.Range(min,max+1);
		text.text = guess.ToString();
	
		maxguessesallowed = maxguessesallowed - 1;
		
		if (maxguessesallowed <=0) {
			Application.LoadLevel("Win");
		}	
		
		}
}
