using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TileGame : MonoBehaviour
{
    [SerializeField]
    private TMP_Text _scoreText;
    [SerializeField]
    private List<GameObject> _tiles = new List<GameObject>();
    [SerializeField]
    private GameObject _grid;

    private TileItem _tile1;
    private TileItem _tile2;
    private int _tileCount = 0;
    private int _totalScore = 0;


    private void Start()
    {
        _totalScore = 0;
        _scoreText.text = _totalScore.ToString();

        for (int i = 0; i < 12; i++)
        {
            GameObject tile = Instantiate(_tiles[Random.Range(0, 3)], transform.position, Quaternion.identity);
            tile.transform.SetParent(_grid.transform);
        }
    }

    public void Shuffle<T>(IList<T> tile)
    {
        var count = tile.Count;
        var last = count - 1;
        for (var i = 0; i < last; ++i)
        {
            var r = Random.Range(i, count);
            var tmp = tile[i];
            tile[i] = tile[r];
            tile[r] = tmp;
        }
    }

    public void AddTile(TileItem tile)
    {
        if (_tileCount < 2)
        {
            if (_tile1 == null)
                _tile1 = tile;
            else
                _tile2 = tile;
            _tileCount++;
        }

        if (_tileCount == 2)
        {
            CompareTiles();
        }
    }

    private void ClearTiles()
    {
        _tileCount = 0;
        _tile1 = null;
        _tile2 = null;
    }

    private void CompareTiles()
    {
        if(_tile1.tag == _tile2.tag)
        {
            ModifyScore(_tile1.GetScore());
            ClearTiles();
        }
        else
        {
            ModifyScore(-1);
            StartCoroutine(WaitToFlip(_tile1, _tile2));
        }
    }

    public void ModifyScore(int score)
    {
        _totalScore += score;
        UpdateScoreText();
    }

    private void UpdateScoreText()
    {
        _scoreText.text = _totalScore.ToString();
    }

    IEnumerator WaitToFlip(TileItem item1, TileItem item2)
    {
        yield return new WaitForSeconds(0.5f);
        item1.CoverItem();
        item2.CoverItem();
        ClearTiles();
    }
}
