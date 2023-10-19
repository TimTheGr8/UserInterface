using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class ChargeButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField]
    private TMP_Text _chargetext;
    [SerializeField]
    private Slider _chargeSlider;
    [SerializeField]
    private Image _sliderFill;
    [SerializeField]
    private Color32 _primaryColor;
    [SerializeField]
    private Color32 _secondaryColor;

    private bool _isCharaging = false;

    public void OnPointerDown(PointerEventData eventData)
    {
        _isCharaging = true;
        _chargetext.text = "CHARGING......";
        StartCoroutine(FillCharge());
        StartCoroutine(FlashColor());
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        _isCharaging = false;
        _chargetext.text = "NOT CHARGING";
        StartCoroutine(EmptyCharge());
    }


    IEnumerator FillCharge()
    {
        while (_isCharaging)
        {
            if (_chargeSlider.value < 1)
            {
                _chargeSlider.value += 0.055f;
            }
            yield return new WaitForSeconds(0.1f);
        }
    }

    IEnumerator EmptyCharge()
    {
        while (!_isCharaging)
        {
            if (_chargeSlider.value <= 1 )
            {
                _chargeSlider.value -= 0.1f;
            }
            yield return new WaitForSeconds(0.1f);
        }
    }

    IEnumerator FlashColor()
    {
        float flashTime = 0.1f;
        while (_isCharaging)
        {
            _sliderFill.color = _primaryColor;
            yield return new WaitForSeconds(flashTime);
            _sliderFill.color = _secondaryColor;
            yield return new WaitForSeconds(flashTime);
        }
    }
}
