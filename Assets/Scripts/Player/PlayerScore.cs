using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;
    [SerializeField] private Text scoreText;

    private void Update()
    {
        scoreText.text = ((int)(playerTransform.position.z / 2)).ToString();
    }
}
