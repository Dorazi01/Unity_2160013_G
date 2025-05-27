using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//ȭ���� ������ �Ʒ��� 1�ʿ� �ϳ��� �������� ��� -> transfrom.Translate()
//ȭ���� ����ȭ�� ������ ������ ȭ�� ������Ʈ�� �Ҹ� ��Ű�� ��� -> Destroy()
public class ArrowController : MonoBehaviour
{
    //������� ����
    GameObject player = null;   //Player Object�� ������ GameObject ����, GameObject ������ �ʱ㰪�� null

    Vector2 vArrowCirclePoint = Vector2.zero; //ȭ���� �ѷ��� ���� �߽� ��ǥ
    Vector2 vPlayerCirclePoint = Vector2.zero; //�÷��̾ �ѷ��� ���� �߽�
    Vector2 vArrowPlayerDir = Vector2.zero; //ȭ�쿡�� �÷��̾������ ���Ͱ�

    float fArrowRadius = 0.5f; //ȭ�� ���� ������ 0.5
    float fPlayerRadius = 1.0f; //�÷��̾��� ������ 1.0
    float fArrowPlayerDistance = 0.0f; //ȭ���� �߽�(vArrowCirclePoint)���� �÷��̾ �ѷ��� ���� �߽�(vPlayerCirclePoint) ������ �Ÿ�
    
    //Start is called once before the first excution of Update after the
    void Start()
   
    {
        /*
         * 
         */
        player = GameObject.Find("player_0");
    }

    void Update()
    {
        /*
        * ȭ���� ������ �Ʒ��� 1�ʿ� �ϳ��� �������� ��� -> transfrom.Translate()
        * Translate �޼���: ������Ʈ�� ���� ��ǥ���� �μ� ����ŭ �̵���Ű�� �޼���
        *   Y��ǥ�� -0.1f�� �����ϸ� ������Ʈ�� ���ݾ� ������ �Ʒ��� �����δ�
        *   �����Ӹ��� ������� ���Ͻ�Ų��
        */

        // �����Ӹ��� ������� ���Ͻ�Ų�� 
        transform.Translate(0, -0.1f, 0);

        /*
         * ȭ���� ����ȭ�� ������ ������ ȭ�� ������Ʈ�� �Ҹ��Ű�� ��� -> Destroy
         * ȭ�� ������ ���� ȭ�� �Ҹ��Ű��
         * ȭ���� �������θ� ȭ�� ������ ������ �ǰ� ���� �������� ������ ��� ������
         * ȭ���� ������ �ʴ� ������ ��� �������� ��ǻ�� ���� ����� �ؾ��ϹǷ� �޸� ����
         * �޸𸮰� ������� �ʵ��� ȭ���� ȭ�� ������ ������ ������Ʈ�� �Ҹ� ���Ѿ���
         * Destroy �޼���: �Ű������� ������ ������Ʈ�� ����
         * �Ű������� �ڽ�(ȭ�� ������Ʈ)�� ����Ű�� gameeObject ������ �����ϹǷ� ȭ����
         * ȭ�� ������ ������ �� �ڱ� �ڽ��� �Ҹ��Ŵ
         */


        // ȭ�� ������ ������ ������Ʈ�� �Ҹ��Ų��
        if (transform.position.y < -5.0f)
        {
            Destroy(gameObject);
        }

        vArrowCirclePoint = transform.position;
        vPlayerCirclePoint = player.transform.position;
        vArrowPlayerDir = vArrowCirclePoint - vPlayerCirclePoint;

        /*
         * �浹 ����:���� �߽� ��ǥ�� �ݰ��� ����� �浹 ���� �˰���
         * ȭ���� �߽�(vArrowCirclePoint)���� �÷��̾ �ѷ��� ���� �߽�( vPlayerCirclePoint)���� �Ÿ�(fArrowPlayerDistance)�� ��Ÿ����� ������ �̿��Ͽ� ���Ѵ�.
         * fArrowRadius: ȭ���� �ѷ��� ���� ������, fPlayerRadius: �÷��̾ �ѷ��� ������
         */

        /*
         * �� ���Ͱ��� ���̸� ���ϴ� �޼��� : magnitude
         * - �޼����� ���� : public float Magnitude(Vertor3 vector);
         * -���ʹ� ũ��� ������ ���� ������, ������(Initial Point)�� ����(Terminl Point)���� �����Ǹ�, �� �� ������ �Ÿ��� �� ������ ũ�Ⱑ �ȴ�
         * -�Ϲ������� �������� ������ ����, ������ ������ �Ӹ���� �θ���
         * - ���ʹ� ���� ��ġ�� ��Ÿ���� ��ġ ����(Position Vector)�� �̿��� ǥ���Ѵ�
         * - ȭ���� �߽�(vArrowCirclePoint)���� �÷��̾ �ѷ��� ���� �߽�(vPlayerCirclePoint)������ �Ÿ�
         */

        fArrowPlayerDistance = vArrowPlayerDir.magnitude;

        /*
         * �浹 ����:���� �߽� ��ǥ�� �ݰ��� ����� �浹 ���� �˰���
         * ȭ���� �߽�(vArrowCirclePoint)���� �÷��̾ �ѷ��� ���� �߽�( vPlayerCirclePoint)���� �Ÿ�(fArrowPlayerDistance)�� ��Ÿ����� ������ �̿��Ͽ� ���Ѵ�.
         * fArrowRadius: ȭ���� �ѷ��� ���� ������, fPlayerRadius: �÷��̾ �ѷ��� ������
         */

        /*
         *�÷��̾ ȭ�쿡 �¾Ҵ��� ����, �� ȭ��� �÷��̾��� �浹 ����
         *-���� �߽� ��ǥ�� �ݰ��� ����� �浹 ����
         *-r1:ȭ���� �ѷ��� ���� ������, r2: �÷��̾ �ѷ��� ���� ������, d:ȭ��� �߽ɿ��� �÷��̾�� �߽ɱ����� �Ÿ�
         *- �浹 : �ο��� �߽� �� �Ÿ� d �� (r1+ r2)���� ������ �浹(d<r1+r2)
         *-���浹: �ο��� �߽� �� ���� d �� (r1+ r2)���� ũ�� �� ���� �浹���� ���� (d<r1+r2)
         *-�浹(fArrowPlayerDistance < (vArrowCirclePoint + fPlayerRadius)) �̸� ȭ�� ������Ʈ �Ҹ�
         */





        if (fArrowPlayerDistance < fArrowRadius + fPlayerRadius)
        {
            //���� ��ũ��Ʈ�� �÷��̾�� ȭ���� �浹�ߴٰ� �����Ѵ�.
            /*
             * �÷��̾ ȭ�쿡 ������ ȭ�� ��Ʈ�ѷο��� ���� ��ũ��Ʈ(GameDirector)�� f_DecreaseHp() �޼��带 ȣ��
             *��, ArrowController���� GameDirector ������Ʈ�� �ִ� f_DecreaseHp�޼��带 ȣ���ϱ� ����
             *Find �޼��带 ã�Ƽ� GameDirector ������Ʈ�� ã�´�.
             */
            GameObject gDirector = GameObject.Find("GameDirector");

            /*
             * GetComponent �޼��带 ����� GameDirector ������Ʈ�� GameDirecto ��ũ��Ʈ�� ���ϰ�
             * f_DecreaseHp() �޼��带 �����Ͽ�, ���� ��ũ��Ʈ�� �÷��̾�� ȭ���� �浹�ߴٰ� ����
             */
            gDirector.GetComponent<GameDirector>().f_DecreaseHp();

            // �浹�� ���� ȭ���� �����
            Destroy(gameObject); //ȭ��� �÷��̾� �浹, ȭ�� ������Ʈ�� �Ҹ�
        }

        if(GameDirector.instance._isDead == true)
        {
            Destroy(gameObject);
        }

    }
}





/*
    // �浹 ����
    Vector2 p1 = transform.position;              // ȭ���� �߽� ��ǥ
    Vector2 p2 = this.player.transform.position;  // �÷��̾��� �߽� ��ǥ
    Vector2 dir = p1 - p2;
    float d = dir.magnitude;
    float r1 = 0.5f;  // ȭ���� �ݰ�
    float r2 = 1.0f;  // �÷��̾��� �ݰ�
    */