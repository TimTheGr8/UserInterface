using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class LoadingScene : MonoBehaviour
{
    [SerializeField]
    private Slider _loadingBar;
    [SerializeField]
    private TMP_Text _loadingValueText;

    private float _loadingValue;

    void Start()
    {
        _loadingValue = 0;
        _loadingBar.value = _loadingValue;
        StartCoroutine(LoadAsyncScene());
    }

    IEnumerator LoadAsyncScene()
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Loading_Bar_Scene_2");

        while(!asyncLoad.isDone)
        {
            _loadingBar.value = asyncLoad.progress;
            _loadingValueText.text = _loadingBar.value.ToString();
            yield return null;
        }
    }
}
