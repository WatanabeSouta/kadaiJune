using UnityEngine;

public class ResetScoreButton : MonoBehaviour
{
    private void Start()
    {
        // �{�^�����N���b�N���ꂽ�Ƃ��ɌĂяo�����\�b�h��ݒ�
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

    // �{�^�����N���b�N���ꂽ�Ƃ��ɌĂяo����郁�\�b�h
    private void ResetScore()
    {
        // ScoreManager1�̃C���X�^���X��T��
        ScoreManager1 scoreManager = FindObjectOfType<ScoreManager1>();

        if (scoreManager != null)
        {
            scoreManager.ResetScore(); // Score�����Z�b�g����
        }
        else
        {
            Debug.LogWarning("ScoreManager1 not found!");
        }
    }
}
