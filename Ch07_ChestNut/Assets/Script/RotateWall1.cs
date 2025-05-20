using UnityEngine;

public class RotateWall1 : MonoBehaviour
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

        if (transform.position.x > 20f)
        {
            speed = 1.0f;
        }
        else if (transform.position.x > 40f)
        {
            speed = 50.0f;
        }

    }

    void Move()
    {
        {
            // �� ������
            transform.Rotate(Vector3.back * direction * speed * Time.deltaTime);
        }
    }
}
