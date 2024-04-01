using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGameScript : MonoBehaviour
{
    private void Start() => Time.timeScale = 0f;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = 1f;
            gameObject.SetActive(false);
        }
    }
}
