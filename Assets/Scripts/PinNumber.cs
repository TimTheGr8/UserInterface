using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PinNumber : MonoBehaviour
{
    [SerializeField]
    private TMP_Text _pinText;
    [SerializeField]
    private string _pinNumber;

    public void AddNumber(string text)
    {
        _pinText.text += text;
    }

    public void ClearPIN()
    {
        _pinText.text = null;
    }

    public void CheckPin()
    {
        if(_pinText.text == _pinNumber)
        {
            Debug.Log("PIN entered correctly!");
        }
        else
        {
            Debug.Log("That is the incorrect PIN. Please try again.");
            _pinText.text = null;
        }
    }
}
