using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenGameOverMenu : MonoBehaviour
{
    [SerializeField] GameObject _menu;
    [SerializeField] PlayerHealth _player;

    private void OnEnable() => _player.PlayerDeath += OpenMenu;

    private void OnDisable() => _player.PlayerDeath -= OpenMenu;

    private void OpenMenu()
    {
        Time.timeScale = 0f;
        _menu.SetActive(true);
    }
}
