using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriviaGameLoop : MonoBehaviour {

	public struct Question
	{
		public string questionText;
		public string[] answers;
		public int correctAnswerIndex;
		public Question(string questionText, string[] answers, int correctAnswerIndex)
		{
			this.questionText = questionText;
			this.answers = answers;
			this.correctAnswerIndex = correctAnswerIndex;
		}
	}
	public Question currentQuestion = new Question("What is your favourite color?", new string[]{"blue","red","yelow","white","black"}, 0);
	public Button[] answerButtons;
	public Text questionText;

	private Question[] questions;

	// Use this for initialization
	void Start () {
		assignQuestion();
	}
	
	

	// Update is called once per frame
	void Update () {
		
	}

	void assignQuestion(){

		questionText.text = currentQuestion.questionText;
		for (int i = 0; i < answerButtons.Length; i++){
			answerButtons[i].GetComponentInChildren<Text>().text = currentQuestion.answers[i];
		}

	}

	public void checkAnswer(int buttonNum){
		if (buttonNum == currentQuestion.correctAnswerIndex){
			print("Correct.");
		}
		else{
			print("Incorrect.");
		}
	}
}
