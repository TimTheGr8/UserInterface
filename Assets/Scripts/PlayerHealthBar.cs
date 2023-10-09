using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerHealthBar : MonoBehaviour
{
    [SerializeField]
    private Slider _healthBar;
    [SerializeField]
    private TMP_Text _healthValue;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            _healthBar.value -= 20;
            _healthValue.text = _healthBar.value.ToString();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            _healthBar.value += 20;
            _healthValue.text = _healthBar.value.ToString();
        }
    }
}
