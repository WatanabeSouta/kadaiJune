using UnityEngine;
using UnityEngine.SceneManagement;

public class StartSceneController : MonoBehaviour
{
    public void StartGame()
    {
        ScoreManager1 scoreManager = FindObjectOfType<ScoreManager1>();
        if (scoreManager != null)
        {
            scoreManager.ResetScore(); // �X�R�A�����Z�b�g����
        }
        SceneManager.LoadScene("Start"); // Start�V�[����ǂݍ���
    }
}
