using UnityEngine;

public class PlaySound : MonoBehaviour
{
    public AudioSource audioSource;

    // ���̃��\�b�h���{�^����OnClick�C�x���g�Ɋ��蓖�Ă܂�
    public void PlayClickSound()
    {
        audioSource.Play();
    }
}
