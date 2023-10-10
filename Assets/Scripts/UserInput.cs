using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UserInput : MonoBehaviour
{
    [SerializeField]
    private TMP_InputField _userName;
    [SerializeField]
    private TMP_InputField _password;
    [SerializeField]
    private TMP_Text _textOutput;

    public void InputUserName()
    {
        PlayerPrefs.SetString("userName", _userName.text);
    }

    public void InputPassword()
    {
        PlayerPrefs.SetString("password", _password.text);
    }

    public void OutputInfo()
    {
        _textOutput.text = $"Your Username is {PlayerPrefs.GetString("userName")} and your Password is {PlayerPrefs.GetString("password")}.";
    }
}
