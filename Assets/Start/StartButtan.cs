using UnityEngine;
using UnityEngine.UI;

public class PointManager : MonoBehaviour
{
    private int points = 0; // �|�C���g�̏����l
    public Text scoreText; // UI�e�L�X�g�ւ̎Q��

    void Start()
    {
        LoadScore(); // �X�R�A�̃��[�h
        UpdateScoreText(); // �X�R�A�e�L�X�g�̍X�V
    }

    // �|�C���g��ǉ�����֐�
    public void AddPoints(int amount)
    {
        points += amount;
        UpdateScoreText(); // �X�R�A�e�L�X�g�̍X�V
        SaveScore(); // �X�R�A�̃Z�[�u
    }

    // �X�R�A�e�L�X�g���X�V����֐�
    void UpdateScoreText()
    {
        scoreText.text = "Score: " + points.ToString(); // �X�R�A���e�L�X�g�ɔ��f
    }

    // �X�R�A���Z�[�u����֐�
    void SaveScore()
    {
        PlayerPrefs.SetInt("Score", points); // �X�R�A��PlayerPrefs�ɕۑ�
        PlayerPrefs.Save(); // �ۑ����m�肳����
    }

    // �X�R�A�����[�h����֐�
    void LoadScore()
    {
        if (PlayerPrefs.HasKey("Score"))
        {
            points = PlayerPrefs.GetInt("Score"); // PlayerPrefs����X�R�A�����[�h
        }
    }
}