using UnityEngine;

public class PlaySound : MonoBehaviour
{
    public AudioSource audioSource;

    // このメソッドをボタンのOnClickイベントに割り当てます
    public void PlayClickSound()
    {
        audioSource.Play();
    }
}
