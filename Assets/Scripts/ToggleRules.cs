using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ToggleRules : MonoBehaviour
{
    [SerializeField]
    private string _rule1, _rule2, _rule3;
    [SerializeField]
    private Toggle[] _toggleRules;
    [SerializeField]
    private Sprite[] _dinoPictures;
    [SerializeField]
    private Image _pictureField;
    [SerializeField]
    private TMP_Text _imageTextField;

    public void ToggleRule()
    {
        if(_toggleRules[0].isOn)
        {
            _imageTextField.text = _rule1;
            _pictureField.sprite = _dinoPictures[0];
        }
        if (_toggleRules[1].isOn)
        {
            _imageTextField.text = _rule2;
            _pictureField.sprite = _dinoPictures[1];
        }
        if (_toggleRules[2].isOn)
        {
            _imageTextField.text = _rule3;
            _pictureField.sprite = _dinoPictures[2];
        }
    }
}
