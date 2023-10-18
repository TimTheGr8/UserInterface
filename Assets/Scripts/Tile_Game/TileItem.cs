using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TileItem : MonoBehaviour
{
    [SerializeField]
    private int _scoreAmount = 1;
    [SerializeField]
    private Image _coverImage;
    
    private TileGame _manager;

    private void Start()
    {
        _manager = GameObject.Find("Manager").GetComponent<TileGame>();
        if (_manager == null)
            Debug.Log("There is no manager for this game");
    }

    public void RevealItem()
    {
        _manager.AddTile(this);
        _coverImage.gameObject.SetActive(false);
        //_manager.ModifyScore(_scoreAmount);
    }

    public int GetScore()
    {
        return _scoreAmount;
    }

    public void CoverItem()
    {
        _coverImage.gameObject.SetActive(true);
    }
}
