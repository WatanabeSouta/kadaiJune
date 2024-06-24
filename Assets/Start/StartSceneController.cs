using UnityEngine;
using UnityEngine.SceneManagement;

public class StartSceneController : MonoBehaviour
{
    public void StartGame()
    {
        ScoreManager1 scoreManager = FindObjectOfType<ScoreManager1>();
        if (scoreManager != null)
        {
            scoreManager.ResetScore(); // スコアをリセットする
        }
        SceneManager.LoadScene("Start"); // Startシーンを読み込む
    }
}
