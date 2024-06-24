using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public void RestartGame()
    {
        ScoreManager1 scoreManager = FindObjectOfType<ScoreManager1>();
        if (scoreManager != null)
        {
            scoreManager.ResetScore(); // スコアをリセットする
        }
        SceneManager.LoadScene("6gatukadai"); // ゲームシーンを再読み込み
    }

    public void GoToNextLevel()
    {
        SceneManager.LoadScene("ScoreScene"); // 次のレベルのシーンを読み込み
    }

    public void ReturnToMainMenu()
    {
        ScoreManager1 scoreManager = FindObjectOfType<ScoreManager1>();
        if (scoreManager != null)
        {
            scoreManager.ResetScore(); // スコアをリセットする
        }
        SceneManager.LoadScene("Stert"); // メインメニューシーンを読み込み
    }
}
