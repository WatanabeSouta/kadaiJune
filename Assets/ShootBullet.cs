using UnityEngine;

public class ShootBullet : MonoBehaviour
{
    public GameObject bulletPrefab;  // 弾丸のプレハブ
    public Transform firePoint;      // 発射ポイント
    public float bulletSpeed = 20f;  // 弾丸の速度
    public float fireRate = 0.5f;    // 発射のクールダウン時間（秒）
    public float maxShootAngle = 30f; // 最大発射角度（度）

    private float lastFireTime;      // 最後に発射した時間

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && Time.time > lastFireTime + fireRate) // 左クリックで発射、かつクールダウンが終了している
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // マウスのスクリーン座標を取得
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = 0f; // 2Dゲームの場合はzを0にする

        // マウスのスクリーン座標をワールド座標に変換
        Vector3 worldMousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        // 発射ポイントからマウスカーソルへの方向を計算
        Vector2 direction = (worldMousePosition - firePoint.position).normalized;

        // 発射方向の角度を計算
        float angle = Vector2.Angle(Vector2.right, direction);

        // 発射角度が制限を超えている場合、発射しない
        if (direction.y > 0 && angle > maxShootAngle)
        {
            Debug.Log("発射角度が制限を超えています。発射しません。");
            return;
        }

        // 弾丸を生成
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);

        // 弾丸にRigidbody2Dコンポーネントがあるか確認
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            // 弾丸に力を加えて発射
            rb.velocity = direction * bulletSpeed;
        }
        else
        {
            Debug.LogError("Rigidbody2Dが弾丸に見つかりませんでした。弾丸プレハブにRigidbody2Dコンポーネントを追加してください。");
        }

        // 最後に発射した時間を更新
        lastFireTime = Time.time;
    }
}
