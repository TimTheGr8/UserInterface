using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PinVerification : MonoBehaviour
{
    [SerializeField]
    private TMP_InputField _createPinText;
    [SerializeField]
    private TMP_InputField _enterPinText;
    [SerializeField]
    private TMP_Text _feedbackText;

    private int _createdPin;
    private int _enteredPin;

    public void CreatePIN()
    {
        if(_createPinText.text.Length < 4)
        {
            _createPinText.text = null;
            _feedbackText.text = "A correct PIN has 4 numbers.";
        }
        else
        {
            _createdPin = int.Parse(_createPinText.text);
            _feedbackText.text = null;
            Debug.Log(_createdPin);
            _createPinText.gameObject.SetActive(false);
            _enterPinText.gameObject.SetActive(true);
        }
    }

    public void EnterPIN()
    {
        _enteredPin = int.Parse(_enterPinText.text);
        if(_enteredPin == _createdPin)
        {
            _feedbackText.text = "You have entered the correct PIN.";
        }
        else
        {
            _enterPinText.text = null;
            _feedbackText.text = "That PIN does not match.";
        }
    }

    private void SelectField(TMP_InputField field)
    {
        field.Select();
    }
}
