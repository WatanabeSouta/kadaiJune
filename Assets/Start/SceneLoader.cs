using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public string ScoreScene; // ‘JˆÚæ‚ÌƒV[ƒ“–¼‚ğInspector‚©‚çİ’è

    public void LoadScene()
    {
        SceneManager.LoadScene("ScoreScene");
    }
}
