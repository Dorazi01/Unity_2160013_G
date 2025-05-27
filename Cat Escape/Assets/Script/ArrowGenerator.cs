/*
 * ȭ�� ������Ʈ�� 1�ʿ� �� ���� �����ϴ� �˰���
 * Update �޼���� �����Ӹ��� ����ǰ� �� �����Ӱ� ���� �������� ������ �ð� ���̴� Time. deltaTime�� ����
 *- �볪�� ���� ���� ������ 1�ʿ� �� ���� ȭ���� ������
 *Instantiate �޼���
 *--������ �����ϴ� ���߿� ���ӿ�����Ʈ�� �����Ҽ� ����
 *--ȭ�� �������� �̿��Ͽ�, ȭ�� �ν��Ͻ��� �����ϴ� �޼���
 *-Random.Range �޼���: ���� ���� ���� ������ �� �ִ� ���
 *-Random Ŭ������ ���� �䱸�Ǵ� �پ��� Ÿ���� ���� ���� ���� ���� �� �� �ִ� ����� ����
 *--����ڰ� ������ �ּڰ��� �ִ� ������ ������ ���ڸ� ������
 *  --ù��° �Ű��������� ũ�ų� ���� �� ��° �Ű��������� ���� �������� ������ ���� �����ϰ� ��ȯ
 */


using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
    public GameObject garrowPrefab = null; //ȭ�� Prefab�� ���� �������Ʈ ���� ����

    GameObject gArrowInstance = null;   //ȭ�� �ν��Ͻ� ���� ����

    float fArrowCreateSpan = 1.0f;  //ȭ�� ���� ���� : ȭ���� 1�ʸ��� ���� ����
    float fDeltaTime = 0.0f;    //�� �����Ӱ� ���� ������ ������ �ð� ���̸� �����ϴ� ����

    int nArrowPositionRance = 0;    //ȭ���� X ��ǥ Range ���� ����

    void Update()
    {
        fDeltaTime  += Time.deltaTime;
        if (fDeltaTime > fArrowCreateSpan)
        {
            fDeltaTime = 0.0f;

            /*
             * Instantiate �޼���: ȭ�� �������� �̿��Ͽ�, ȭ�� �ν��Ͻ��� �����ϴ� �޼���
             * -�Ű������� �������� �����ϸ�, ��ȯ������ ������ �ν��Ͻ��� �����ش�
             * Instatiate �޼��带 ����ϸ� ������ �����ϴ� ���߿� ���ӿ�����Ʈ�� ������ �� ����
             * RPG �����̶�� ������ ������, ĳ����, ��� �� ���͵��� ��� �̸� ����� ������������?
             *  �׷��Ƿ� ���ӿ�����Ʈ�� �������� ����
             *  - Instatiate(GameObject original, Vector3 position, Quaternion rotation)
             *  -- Object original : �����ϰ��� �ϴ� ���� ������Ʈ��, ���� ���� �ִ� ���� ������Ʈ�� Prefab���� ����� ��ü�� �ǹ���
             *  -- Vector3 position : Vector3���� ������ ��ġ�� ������
             *  -- Quatenion rotation: ������ ���ӿ��������� ȸ������ ����
             */

            gArrowInstance = Instantiate(garrowPrefab);

            /*
             * Random Ŭ������ ���� �䱸�Ǵ� �پ��� Ÿ���� ���� ���� ���� ������ �� �ִ� ����� ����
             * Random.Range �޼���: ����ڰ� ������ �ּڰ��� �ִ밪 ������ ������ ���ڸ� ������
             * -������ �ּڰ��� �ִ��� �������� �Ǽ������� ���� ���� �Ǵ� �Ǽ��� ��ȯ��
             * -ȭ���� X��ǥ�� -6 ~ 6���̿� �ұ�Ģ�ϰ� ��ġ
             */

            nArrowPositionRance = Random.Range(-6, 7);
            gArrowInstance.transform.position = new Vector3(nArrowPositionRance, 7, 0);
        }
    }
}
