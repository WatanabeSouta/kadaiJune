using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TaggedButtonController : MonoBehaviour
{
    public string sceneToLoad; // ボタンが押されたときに遷移するシーンの名前

    private void Start()
    {
        // ボタンがクリックされたときの処理を設定
        Button button = GetComponent<Button>(); // ボタンのコンポーネントを取得
        button.onClick.AddListener(OnButtonClicked); // ボタンがクリックされたときに呼び出すメソッドを設定
    }

    private void OnButtonClicked()
    {
        Debug.Log("Button clicked: " + gameObject.tag); // クリックされたボタンのタグをログに出力

        if (gameObject.CompareTag("Start"))
        {
            Debug.Log("Start button clicked, loading '6gatukadai' scene.");
            SceneManager.LoadScene("6gatukadai", LoadSceneMode.Single);
        }
        else if (gameObject.CompareTag("Score"))
        {
            Debug.Log("Score button clicked, loading 'Start' scene.");
            SceneManager.LoadScene("Start", LoadSceneMode.Single);
        }
        else
        {
            Debug.LogWarning("Unknown button tag: " + gameObject.tag);
        }
    }

}
