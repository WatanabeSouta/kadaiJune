using UnityEngine;

public class ResetScoreButton : MonoBehaviour
{
    private void Start()
    {
        // ボタンがクリックされたときに呼び出すメソッドを設定
        UnityEngine.UI.Button button = GetComponent<UnityEngine.UI.Button>();
        if (button != null)
        {
            button.onClick.AddListener(ResetScore);
        }
        else
        {
            Debug.LogWarning("Button component not found on GameObject!");
        }
    }

    // ボタンがクリックされたときに呼び出されるメソッド
    private void ResetScore()
    {
        // ScoreManager1のインスタンスを探す
        ScoreManager1 scoreManager = FindObjectOfType<ScoreManager1>();

        if (scoreManager != null)
        {
            scoreManager.ResetScore(); // Scoreをリセットする
        }
        else
        {
            Debug.LogWarning("ScoreManager1 not found!");
        }
    }
}
