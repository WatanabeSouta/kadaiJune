using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public string ScoreScene; // �J�ڐ�̃V�[������Inspector����ݒ�

    public void LoadScene()
    {
        SceneManager.LoadScene("ScoreScene");
    }
}
