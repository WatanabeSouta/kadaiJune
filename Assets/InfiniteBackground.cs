using UnityEngine;

public class InfiniteBackground : MonoBehaviour
{
    /// <summary>背景のスクロール速度</summary>
    [SerializeField] private float scrollSpeed = 0.5f;
    /// <summary>背景画像のサイズ</summary>
    private float backgroundSize;
    /// <summary>カメラの参照</summary>
    private Transform cameraTransform;
    /// <summary>最後にカメラの位置を保存する</summary>
    private Vector3 lastCameraPosition;
    /// <summary>背景のSpriteRenderer</summary>
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        // SpriteRendererを取得
        spriteRenderer = GetComponent<SpriteRenderer>();
        if (spriteRenderer == null)
        {
            Debug.LogError("SpriteRendererが見つかりません。スクリプトを正しいGameObjectにアタッチしてください。");
            return;
        }

        // カメラの参照を取得
        cameraTransform = Camera.main.transform;
        // 最後のカメラ位置を保存
        lastCameraPosition = cameraTransform.position;
        // 背景画像のサイズを取得
        backgroundSize = spriteRenderer.bounds.size.x;
    }

    void Update()
    {
        if (spriteRenderer == null)
        {
            return;
        }

        // カメラの移動量を計算
        float deltaX = cameraTransform.position.x - lastCameraPosition.x;

        // 背景の移動
        transform.position += Vector3.right * deltaX * scrollSpeed;

        // 最後のカメラ位置を更新
        lastCameraPosition = cameraTransform.position;

        // 背景の位置をリセット
        if (cameraTransform.position.x - transform.position.x >= backgroundSize)
        {
            RepositionBackground();
        }
    }

    private void RepositionBackground()
    {
        Vector3 offset = new Vector3(backgroundSize * 2f, 0);
        transform.position += offset;
    }
}
