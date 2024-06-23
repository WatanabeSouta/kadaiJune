using UnityEngine;

public class ShootBullet : MonoBehaviour
{
    public GameObject bulletPrefab;  // �e�ۂ̃v���n�u
    public Transform firePoint;      // ���˃|�C���g
    public float bulletSpeed = 20f;  // �e�ۂ̑��x
    public float fireRate = 0.5f;    // ���˂̃N�[���_�E�����ԁi�b�j
    public float maxShootAngle = 30f; // �ő唭�ˊp�x�i�x�j

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
        // �}�E�X�̃X�N���[�����W���擾
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = 0f; // 2D�Q�[���̏ꍇ��z��0�ɂ���

        // �}�E�X�̃X�N���[�����W�����[���h���W�ɕϊ�
        Vector3 worldMousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        // ���˃|�C���g����}�E�X�J�[�\���ւ̕������v�Z
        Vector2 direction = (worldMousePosition - firePoint.position).normalized;

        // ���˕����̊p�x���v�Z
        float angle = Vector2.Angle(Vector2.right, direction);

        // ���ˊp�x�������𒴂��Ă���ꍇ�A���˂��Ȃ�
        if (direction.y > 0 && angle > maxShootAngle)
        {
            Debug.Log("���ˊp�x�������𒴂��Ă��܂��B���˂��܂���B");
            return;
        }

        // �e�ۂ𐶐�
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);

        // �e�ۂ�Rigidbody2D�R���|�[�l���g�����邩�m�F
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            // �e�ۂɗ͂������Ĕ���
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
