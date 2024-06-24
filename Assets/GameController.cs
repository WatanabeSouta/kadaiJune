using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public void RestartGame()
    {
        ScoreManager1 scoreManager = FindObjectOfType<ScoreManager1>();
        if (scoreManager != null)
        {
            scoreManager.ResetScore(); // �X�R�A�����Z�b�g����
        }
        SceneManager.LoadScene("6gatukadai"); // �Q�[���V�[�����ēǂݍ���
    }

    public void GoToNextLevel()
    {
        SceneManager.LoadScene("ScoreScene"); // ���̃��x���̃V�[����ǂݍ���
    }

    public void ReturnToMainMenu()
    {
        ScoreManager1 scoreManager = FindObjectOfType<ScoreManager1>();
        if (scoreManager != null)
        {
            scoreManager.ResetScore(); // �X�R�A�����Z�b�g����
        }
        SceneManager.LoadScene("Stert"); // ���C�����j���[�V�[����ǂݍ���
    }
}
