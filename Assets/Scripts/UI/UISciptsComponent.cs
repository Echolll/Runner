using UnityEngine;
using UnityEngine.SceneManagement;

public class UISciptsComponent : MonoBehaviour
{
    [SerializeField]Runner.Scene _scene;
    [SerializeField] GameObject _pauseRef;

    public void StartGame()
    {
        SceneManager.LoadScene(_scene.ToString());
    }

    public void RestratGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ContinueGame()
    {
        Time.timeScale = 1f;
        _pauseRef.gameObject.SetActive(false);
    }

    public void CloseGame()
    {
        Application.Quit();
    }
}
