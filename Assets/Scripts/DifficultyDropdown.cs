using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DifficultyDropdown : MonoBehaviour
{
    [SerializeField]
    private TMP_Dropdown _difficultyDropdown;
    [SerializeField]
    private TMP_Text _feedbackText;

    private void Start()
    {
        _feedbackText.text = $"The curernt difficulty is {_difficultyDropdown.options[_difficultyDropdown.value].text}.";
    }

    public void ReturnDifficulty()
    {
        _feedbackText.text = $"You have selected {_difficultyDropdown.options[_difficultyDropdown.value].text} difficulty.";
    }
}
