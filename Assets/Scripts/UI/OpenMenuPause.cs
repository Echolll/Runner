using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenMenuPause : MonoBehaviour
{
    [SerializeField] GameObject _pauseMenu;
   
    void Update()
    {       
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            GetPause();
        }       
    }

    private void GetPause()
    {
        if(_pauseMenu.activeSelf == false)
        {
            _pauseMenu.SetActive(true);
            Time.timeScale = 0f;
        }
        else
        {
            _pauseMenu.SetActive(false);
            Time.timeScale = 1f;
        }
    }
}
