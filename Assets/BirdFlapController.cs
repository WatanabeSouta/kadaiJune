using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// キャラクターを制御するコンポーネント
/// キャラクターにアタッチして使う。Rigidbody2D を必要とする。
/// スペースキーでジャンプする。
/// 何かにぶつかったらゲームオーバーにする。
/// </summary>
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Animator))]
public class BirdFlapController : MonoBehaviour
{
    /// <summary>スペースキーを押した時に上昇する力</summary>
    [SerializeField] private float jumpPower = 1f;
    /// <summary>キャラクターの移動速度</summary>
    [SerializeField] private float moveSpeed = 5f;
    /// <summary>Game Over を表示するオブジェクト</summary>
    [SerializeField] private GameObject gameoverTextObject = null;
    /// <summary>経過時間を表示するオブジェクト</summary>
    [SerializeField] private GameObject timeTextObject = null;
    /// <summary>ゲームオーバーかどうかを判断するフラグ</summary>
    private bool isGameOver = false;
    private Animator anim;
    private Rigidbody2D rb;

    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();

        if (gameoverTextObject == null)
        {
      //      Debug.LogError("GameOverTextオブジェクトが見つかりません。");
        }

        if (timeTextObject == null)
        {
       //     Debug.LogError("TimeTextオブジェクトが見つかりません。");
        }
    }

    void Update()
    {
        if (isGameOver)
        {
            return;
        }

        // WASD キーによる移動
        float moveX = Input.GetAxis("Horizontal") * moveSpeed;
        float moveY = Input.GetAxis("Vertical") * moveSpeed;
        rb.velocity = new Vector2(moveX, moveY);

        // スペースキーが押されたら上昇する
        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.Play("Flap");
            rb.velocity = new Vector2(rb.velocity.x, 0); // Reset vertical velocity for consistent jumps
            rb.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
        }

        // TimeText にプレイ時間を表示する
        if (timeTextObject != null)
        {
            timeTextObject.GetComponent<Text>().text = Time.time.ToString("F2"); // Display elapsed time
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (isGameOver)
        {
            return;
        }

        Debug.Log("何かにぶつかった！");

        // 何かにぶつかったらゲームオーバーとする
        isGameOver = true;

        if (gameoverTextObject != null)
        {
            // 画面に Game Over と表示する
            Text gameoverText = gameoverTextObject.GetComponent<Text>();
            gameoverText.text = "Game Over";
        }
    }
}
