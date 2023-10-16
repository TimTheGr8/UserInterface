using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private GameObject _sphere;
    [SerializeField]
    private GameObject _pauseMenu;
    [SerializeField]
    private Transform _spawnPoint;

    private bool _dropBall = true;
    private bool _isGamePaused = false;

    void Start()
    {
        StartCoroutine(DropBall());
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SwitchSettingsMenu();
        }
    }

    public void SwitchSettingsMenu()
    {
        if (!_isGamePaused)
        {
            _isGamePaused = true;
            Time.timeScale = 0.0f;
            _pauseMenu.SetActive(true);
        }
        else if (_isGamePaused)
        {
            _isGamePaused = false;
            Time.timeScale = 1.0f;
            _pauseMenu.SetActive(false);
        }
    }

    IEnumerator DropBall()
    {
        while (_dropBall)
        {
            GameObject ball = Instantiate(_sphere, _spawnPoint.transform.position, Quaternion.identity);
            yield return new WaitForSeconds(1.0f);
            Destroy(ball, 1.0f);
        }
    }


}
