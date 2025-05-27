using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //�ɹ� ���� ����
    float fMaxPositionX = 9.0f; //�÷��̾ ��, �� �̵��� ���� â�� ����� �ʵ��� Vecter �ִ밪�� ���� ����
    float fMinPositionX = -9.0f; //�÷��̾ ��, �� �̵��� ���� â�� ����� �ʵ��� Vecter �ּڰ��� ���� ����
    float fPositionX = 0.0f; //�÷��̾ ��, �� �̵��� �� �ִ� X ��ǥ ���� ����
    /*
     *Start �޼���
     *�̸� ���ǵ� Ư�� �̺�Ʈ �Լ�(�޼ҵ�)�ν�, �� Ư�� �Լ����� C#������ �Լ��� �޼ҵ��� ��
     *MonoBehaviour Ŭ������ �ʱ�ȭ �� �� ȣ�� �Ǵ� �̺�Ʈ �Լ�
     *���α׷��� ������ �� �� ���� ȣ���� �Ǵ� �Լ��� ���� ������Ʈ�� �޾ƿ��ų� ������Ʈ�� �ٸ� �Լ����� ����ϱ� ���� �ʱ�ȭ ���ִ� ���
     *��, Start() �޼���� ��ũ��Ʈ �ν��Ͻ��� Ȱ��ȭ�� ��쿡�� ù ���� ������ ������Ʈ ���� ȣ���ϹǷ� �ѹ��� ����
     *�� ���¿� ���Ե� ��� ������Ʈ�� ���� Update �� ������ ȣ��� ��� ��ũ��Ʈ�� ���� Start �Լ��� ȣ��
     *���� ���� �÷��� ���� ������Ʈ�� �ν��Ͻ�ȭ�� ���� ������� ����
     */
    void Start()
    {
        /*
         * ����̽� ���ɿ� ���� ���� ����� ���� ���ֱ�
         *  � ������ ��ǻ�Ϳ��� �����ص� ���� �ӵ��� �����̵��� �ϴ� ó��
         *  ����Ʈ���� 60, ����� PC�� 300�� �� �� �ִ� ����̽� ���ɿ� ���� ���� ���ۿ� ������ ��ĥ �� ����
         *  �����ӷ���Ʈ�� 60���� ����
         */

        Application.targetFrameRate = 60; //Application.targetFrameRate = 60;
    }

    //Update is called once per frame

    public void LButtonDown()
    {
        /*
         * Ű�� ���ȴ��� �����ϱ� ���ؼ��� Input Ŭ������ GetKeyDown �޼��带 �����
         * �� �޼���� �Ű����� ������ Ű�� ������ ���� true�� �� �� ��ȯ
         * GetKeyDown �޼���� ���ݱ��� ����ϴ� GetMouseButtonDown �޼���� ����ϹǷ� ���� ������ �� ���� ��
         * Ű�� ���� ����: GetKeyDown()
         * Ű�� ������ �մ� ����: GetKey()
         * Ű�� �����ٰ� �� ����: GetKeyUp()
         */
        //���� ȭ��ǥ Ű�� ������ �� -> GetKeyDown(KeyCode.LetArrow)
        //���� -3�̹Ƿ� �������� 3��ŭ �̵�
        if (GameDirector.instance._isDead == false)
        {
            transform.Translate(-2, 0, 0);
        }


        fPositionX = Mathf.Clamp(transform.position.x, fMinPositionX, fMaxPositionX);
        transform.position = new Vector3(fPositionX, transform.position.y, transform.position.z);
    }

    public void RButtonDown()
    {
        //������ ȭ��ǥ Ű�� ������ �� -> GetKeyDown(KeyCode.RightArrow)
        //���� 3�̹Ƿ� ���������� 3��ŭ �̵�
        if (GameDirector.instance._isDead == false)
        {
            transform.Translate(2, 0, 0);

        }

        /*
         * Mathf.Clamp(value, min, max) �޼���
         *  Ư�� ���� ��� ������ ���ѽ�Ű���� �� �� ����ϴ� �޼���
         *  value ���� ���� : min <= value <= max
         *  �ּ�/�ִ밪�� �����Ͽ� ������ ���� �̿ܿ� ���� ���� �ʵ��� �� �� ���
         *  �÷��̾ ������ �� �ִ� �ּ�(fMinPositionX)/�ִ�(fMaxPositionX) �������� �����Ͽ� �� ������ ����� �ʵ��� �Ѵ�.
        */

        fPositionX = Mathf.Clamp(transform.position.x, fMinPositionX, fMaxPositionX);
        transform.position = new Vector3(fPositionX, transform.position.y, transform.position.z);


    }

     void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) && GameDirector.instance._isDead == false)
        {
            transform.position += new Vector3(-2, 0, 0);
        }

        else if (Input.GetKeyDown(KeyCode.RightArrow) && GameDirector.instance._isDead == false)
        {
            transform.position += new Vector3(2, 0, 0);
        }

        fPositionX = Mathf.Clamp(transform.position.x, fMinPositionX, fMaxPositionX);
        transform.position = new Vector3(fPositionX, transform.position.y, transform.position.z);
    }

}

