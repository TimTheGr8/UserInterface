using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ChangeMenu : MonoBehaviour
{
    [SerializeField]
    private GameObject _menu1;
    [SerializeField]
    private GameObject _menu2;
    [SerializeField]
    private Button _menu2ButtonToSelect;

    private EventSystem _mySystem;

    private void Start()
    {
        _mySystem = GameObject.Find("EventSystem").GetComponent<EventSystem>();
        if (_mySystem == null)
            Debug.LogError("There is no Event System.");
    }

    public void NewMenu()
    {
        _menu2.SetActive(true);
        _menu1.SetActive(false);

        _menu2ButtonToSelect.Select();
    }
}
