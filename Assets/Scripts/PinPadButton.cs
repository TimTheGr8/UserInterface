using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PinPadButton : MonoBehaviour
{
    [SerializeField]
    private int _buttonNumber;
    [SerializeField]
    private PinNumber _pinNumber;

    public void SendNumber()
    {
        _pinNumber.AddNumber(_buttonNumber.ToString());
    }
}
