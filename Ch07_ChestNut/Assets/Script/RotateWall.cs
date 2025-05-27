using UnityEngine;

public class RotateWall : MonoBehaviour
{
    public float speed = 1.0f;  // ���� �����̴� �ӵ�

    private int direction = 1;  // 1�̸� ������ -1�̸� ����

    void Start()
    {
       
    }

    void Update()
    {

        if (this.gameObject.tag == "MovingWall")
        {
            Move();
        }

        

    }

    void Move()
    {
        {
            // �� ������
            transform.Rotate(Vector3.forward * direction * speed * Time.deltaTime);
        }
    }
}
