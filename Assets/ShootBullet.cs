using UnityEngine;

public class ShootBullet : MonoBehaviour
{
    public GameObject bulletPrefab;  // 弾丸のプレハブ
    public Transform firePoint;      // 発射ポイント
    public float bulletSpeed = 20f;  // 弾丸の速度
    public float fireRate = 0.5f;    // 発射のクールダウン時間（秒）

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
        // 発射方向を右方向に設定
        Vector2 direction = Vector2.right;

        // 弾丸を生成
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);

        // 弾丸にRigidbody2Dコンポーネントがあるか確認
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            // 弾丸に力を加えて右方向に発射
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
