using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIValidate : MonoBehaviour
{
    [SerializeField] GameObject _startGameUI;
    [SerializeField] GameObject _gameOverUI;
    [SerializeField] GameObject _pauseUI;
    [SerializeField] GameObject _scoreBarUI;

    private void Start()
    {
        if (_startGameUI == null)
        {
            Debug.LogError($"Нет ссылки на объект - {_startGameUI}");
        }
        if (_gameOverUI == null)
        {
            Debug.LogError($"Нет ссылки на объект - {_gameOverUI}");
        }
        if (_pauseUI == null)
        {
            Debug.LogError($"Нет ссылки на объект - {_pauseUI}");
        }
        if (_scoreBarUI == null)
        {
            Debug.LogError($"Нет ссылки на объект - {_scoreBarUI}");
        }
    }

    void Update()
    {
        if(_startGameUI.activeSelf == false && _gameOverUI.activeSelf == false && _pauseUI.activeSelf == false)
        {
            _scoreBarUI.SetActive(true);
        }

        if(_pauseUI.activeSelf == true && _gameOverUI.activeSelf == false)
        {
            _scoreBarUI.SetActive(false);
        }

        if( _gameOverUI.activeSelf == true && _pauseUI.activeSelf == true)
        {
            _pauseUI.SetActive(false);
            _scoreBarUI.SetActive(false);
        }

        if(_gameOverUI.activeSelf == true)
        {
            _pauseUI.SetActive(false);
            _scoreBarUI.SetActive(false);
        }

    }
}
