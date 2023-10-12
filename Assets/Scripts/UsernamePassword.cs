using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UsernamePassword : MonoBehaviour
{
    [SerializeField]
    private GameObject _login;
    [SerializeField]
    private GameObject _create;
    [SerializeField]
    private TMP_InputField _loginUsernameInput;
    [SerializeField]
    private TMP_InputField _loginPasswordInput;
    [SerializeField]
    private TMP_InputField _createUsernameInput;
    [SerializeField]
    private TMP_InputField _createPasswordInput;
    [SerializeField]
    private TMP_Text _feedbackText;

    private string _enteredUsername;
    private string _enteredPassword;
    private string _username;
    private string _password;

    public void LoginUser()
    {
        _feedbackText.text = null;
        _enteredUsername = _loginUsernameInput.text;
        _enteredPassword = _loginPasswordInput.text;

        if(_enteredUsername != _username || _enteredUsername == null)
        {
            _feedbackText.text = "The username you entered was not found. Do you need to create an account?";
        }
        else if(_enteredPassword != _password || _enteredPassword == null)
        {
            _feedbackText.text = "The password does not match the username. Do you need to create an account?";
        }
        else
        {
            _feedbackText.text = $"You have logged in as {_username}.";
        }
    }

    public void CreateUser()
    {
        _enteredUsername = _createUsernameInput.text;
        _enteredPassword = _createPasswordInput.text;

        if (_enteredUsername.Length <= 2)
        {
            _feedbackText.text = "The username must contain more than 2 characters.";
        }
        else if(_enteredPassword.Length < 4)
        {
            _feedbackText.text = "The password must contain more than 4 characters.";
        }
        else
        {
            _username = _enteredUsername;
            _password = _enteredPassword;
            _feedbackText.text = $"Your account has been cretaed. Welcome {_username}!";
        }
        Debug.Log($"USR: {_username} PASS: {_password}");
    }

    public void LoginScreen()
    {
        _feedbackText.text = null;
        _loginUsernameInput.text = null;
        _loginPasswordInput.text = null;
        _create.SetActive(false);
        _login.SetActive(true);
    }

    public void CreateScreen()
    {
        _feedbackText.text = null;
        _createUsernameInput.text = null;
        _createPasswordInput.text = null;
        _login.SetActive(false);
        _create.SetActive(true);
    }
}
