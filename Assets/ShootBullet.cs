using UnityEngine;

public class ShootBullet : MonoBehaviour
{
    public GameObject bulletPrefab;  // �e�ۂ̃v���n�u
    public Transform firePoint;      // ���˃|�C���g
    public float bulletSpeed = 20f;  // �e�ۂ̑��x
    public float fireRate = 0.5f;    // ���˂̃N�[���_�E�����ԁi�b�j

    private float lastFireTime;      // �Ō�ɔ��˂�������

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && Time.time > lastFireTime + fireRate) // ���N���b�N�Ŕ��ˁA���N�[���_�E�����I�����Ă���
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // ���˕������E�����ɐݒ�
        Vector2 direction = Vector2.right;

        // �e�ۂ𐶐�
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);

        // �e�ۂ�Rigidbody2D�R���|�[�l���g�����邩�m�F
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            // �e�ۂɗ͂������ĉE�����ɔ���
            rb.velocity = direction * bulletSpeed;
        }
        else
        {
            Debug.LogError("Rigidbody2D���e�ۂɌ�����܂���ł����B�e�ۃv���n�u��Rigidbody2D�R���|�[�l���g��ǉ����Ă��������B");
        }

        // �Ō�ɔ��˂������Ԃ��X�V
        lastFireTime = Time.time;
    }
}
