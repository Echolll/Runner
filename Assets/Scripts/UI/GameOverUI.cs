using TMPro;
using UnityEngine;

public class GameOverUI : MonoBehaviour
{
    [SerializeField] PlayerScore _score;
    [SerializeField] TMP_Text _text;

    private void Awake()
    {
        if(_score == null)
        {
            Debug.LogError($"��� ������ �� ������ - {_score}");
        }
        
        if (_text == null)
        {
            Debug.LogError($"��� ������ �� ������ - {_text}");
        }
    }

    private void OnEnable()
    {
        _text.text = _score.score.ToString();
    }
}
