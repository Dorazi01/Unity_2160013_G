using UnityEngine;

public class WallMove : MonoBehaviour
{
    public float speed = 1.0f;  // ���� �����̴� �ӵ�

    private int direction = 1;  // 1�̸� ������ -1�̸� ����



    void Update()
    {
        //���� �±װ� �����̴� ���� �����̰� ����
        if (this.gameObject.tag == "MovingWall")
        {
            Move();
        }

        if (transform.position.y > 20f)
        {
            speed = 1.0f;
        }
        else if (transform.position.y > 40f)
        {
            speed = 50.0f;
        }


    }


    void Move()
    {
        {
            // �� ������
            transform.Translate(Vector2.right * direction * speed * Time.deltaTime);

            // ���� ������ �Ѿ�� ������ȯ
            if (transform.position.x >= 2)
            {
                direction = -1;

            }
            else if (transform.position.x <= -2)
            {
                direction = 1;

            }

            if (transform.position.y >= 9)
            {
                direction = -1;

            }
            else if (transform.position.y <= 5)
            {
                direction = 1;

            }
        }
    }



}

