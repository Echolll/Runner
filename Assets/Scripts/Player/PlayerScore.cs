using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour
{
    [SerializeField] private PlayerHealth _currectPlayer;
    [SerializeField] private TMP_Text _scoreText;
    [SerializeField] private TMP_Text _healthText;

    public int score;

    private void Update()
    {
        score = ((int)(_currectPlayer.gameObject.transform.position.z / 2));
        _scoreText.text = $"Points:{score}";
        int health = _currectPlayer.HealthPoint;
        _healthText.text = $"Health:{health}";
    }
}
