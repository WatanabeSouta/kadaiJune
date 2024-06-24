using UnityEngine;
using UnityEngine.UI;

public class PointManager : MonoBehaviour
{
    private int points = 0; // ポイントの初期値
    public Text scoreText; // UIテキストへの参照

    void Start()
    {
        LoadScore(); // スコアのロード
        UpdateScoreText(); // スコアテキストの更新
    }

    // ポイントを追加する関数
    public void AddPoints(int amount)
    {
        points += amount;
        UpdateScoreText(); // スコアテキストの更新
        SaveScore(); // スコアのセーブ
    }

    // スコアテキストを更新する関数
    void UpdateScoreText()
    {
        scoreText.text = "Score: " + points.ToString(); // スコアをテキストに反映
    }

    // スコアをセーブする関数
    void SaveScore()
    {
        PlayerPrefs.SetInt("Score", points); // スコアをPlayerPrefsに保存
        PlayerPrefs.Save(); // 保存を確定させる
    }

    // スコアをロードする関数
    void LoadScore()
    {
        if (PlayerPrefs.HasKey("Score"))
        {
            points = PlayerPrefs.GetInt("Score"); // PlayerPrefsからスコアをロード
        }
    }
}