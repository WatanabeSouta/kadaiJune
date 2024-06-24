using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeManager : MonoBehaviour
{
    private AudioSource audioSourceSE;
    public AudioClip se;

    public static SeManager Instance { get; private set; }

    void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        audioSourceSE = GetComponent<AudioSource>();
        if (audioSourceSE == null)
        {
            Debug.LogError("AudioSource component missing from this game object.");
        }
    }

    public void SettingPlaySE()
    {
        if (audioSourceSE != null && se != null)
        {
            audioSourceSE.PlayOneShot(se);
        }
        else
        {
            Debug.LogError("Cannot play sound effect. AudioSource or AudioClip is missing.");
        }
    }
}
