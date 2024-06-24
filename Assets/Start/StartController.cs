using UnityEngine;
using UnityEngine.SceneManagement;

public class StartController : MonoBehaviour
{
    public void SwitchScene()
    {
        ScoreManager1 scoreManager = FindObjectOfType<ScoreManager1>();
        if (scoreManager != null)
        {
            Debug.Log("SwitchScene method called"); // デバッグメッセージ
            SceneManager.LoadScene("Start", LoadSceneMode.Single);
        }
        else
        {
            Debug.LogWarning("ScoreManager1 not found in the scene!");
        }
    }
}
