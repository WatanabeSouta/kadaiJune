using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    // "Asobikata" シーンに遷移するメソッド
    public void ChangeToAsobikata()
    {
        SceneManager.LoadScene("Asobikata");
    }
}
