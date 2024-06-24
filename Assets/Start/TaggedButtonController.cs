using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TaggedButtonController : MonoBehaviour
{
    public string sceneToLoad; // �{�^���������ꂽ�Ƃ��ɑJ�ڂ���V�[���̖��O

    private void Start()
    {
        // �{�^�����N���b�N���ꂽ�Ƃ��̏�����ݒ�
        Button button = GetComponent<Button>(); // �{�^���̃R���|�[�l���g���擾
        button.onClick.AddListener(OnButtonClicked); // �{�^�����N���b�N���ꂽ�Ƃ��ɌĂяo�����\�b�h��ݒ�
    }

    private void OnButtonClicked()
    {
        Debug.Log("Button clicked: " + gameObject.tag); // �N���b�N���ꂽ�{�^���̃^�O�����O�ɏo��

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
