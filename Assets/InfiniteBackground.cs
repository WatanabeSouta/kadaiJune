using UnityEngine;

public class InfiniteBackground : MonoBehaviour
{
    /// <summary>�w�i�̃X�N���[�����x</summary>
    [SerializeField] private float scrollSpeed = 0.5f;
    /// <summary>�w�i�摜�̃T�C�Y</summary>
    private float backgroundSize;
    /// <summary>�J�����̎Q��</summary>
    private Transform cameraTransform;
    /// <summary>�Ō�ɃJ�����̈ʒu��ۑ�����</summary>
    private Vector3 lastCameraPosition;
    /// <summary>�w�i��SpriteRenderer</summary>
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        // SpriteRenderer���擾
        spriteRenderer = GetComponent<SpriteRenderer>();
        if (spriteRenderer == null)
        {
            Debug.LogError("SpriteRenderer��������܂���B�X�N���v�g�𐳂���GameObject�ɃA�^�b�`���Ă��������B");
            return;
        }

        // �J�����̎Q�Ƃ��擾
        cameraTransform = Camera.main.transform;
        // �Ō�̃J�����ʒu��ۑ�
        lastCameraPosition = cameraTransform.position;
        // �w�i�摜�̃T�C�Y���擾
        backgroundSize = spriteRenderer.bounds.size.x;
    }

    void Update()
    {
        if (spriteRenderer == null)
        {
            return;
        }

        // �J�����̈ړ��ʂ��v�Z
        float deltaX = cameraTransform.position.x - lastCameraPosition.x;

        // �w�i�̈ړ�
        transform.position += Vector3.right * deltaX * scrollSpeed;

        // �Ō�̃J�����ʒu���X�V
        lastCameraPosition = cameraTransform.position;

        // �w�i�̈ʒu�����Z�b�g
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
