using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MathGame : MonoBehaviour
{
    [SerializeField]
    private TMP_Text _number1Text;
    [SerializeField]
    private TMP_Text _number2Text;
    [SerializeField]
    private TMP_Text _feedbackText;
    [SerializeField]
    private TMP_InputField _answerField;
    [SerializeField]
    private int _minValue = 1;
    [SerializeField]
    private int _maxValue = 50;

    private int _number1;
    private int _number2;
    private int _answer;
    private int _userAnswer;

    private void Start()
    {
        _feedbackText.text = null;
        GenerateEquation();
    }

    private int RandomNumber()
    {
        return Random.Range(_minValue, _maxValue + 1);
    }

    private void GenerateEquation()
    {
        _number1 = RandomNumber();
        _number2 = RandomNumber();
        _answer = _number1 + _number2;

        _number1Text.text = _number1.ToString();
        _number2Text.text = _number2.ToString();
    }

    public void CheckAnswer()
    {
        _userAnswer = int.Parse(_answerField.text);

        if(_userAnswer == _answer)
        {
            _feedbackText.text = "CORRECT";
        }
        else
        {
            _feedbackText.text = $"Incorrect. The correct answer is {_answer}.";
        }
    }

    public void NewEquation()
    {
        _answerField.text = null;
        _feedbackText.text = null;
        GenerateEquation();
    }
}
