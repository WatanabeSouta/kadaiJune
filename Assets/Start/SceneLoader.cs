using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public string ScoreScene; // 遷移先のシーン名をInspectorから設定

    public void LoadScene()
    {
        SceneManager.LoadScene("ScoreScene");
    }
}
