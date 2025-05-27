using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.UI; // UI�� ����ϹǷ� ���� �ʰ� �߰�

public class GameDirector : MonoBehaviour
{
    GameObject ghpGauge;
    public GameObject _GameOver;
 
    public static GameDirector instance = null; // �ٸ���ũ��Ʈ���� �����ϱ����� �ν��Ͻ�ȭ

    public bool _isDead = false;
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        /*
         * �� ������Ʈ ���ڿ� �����ϴ� ������Ʈ�� �� �ȿ��� ã�� �־�� ��
         * �� �ȿ��� ������Ʈ�� ã�� �޼���: Find
         * �μ� �̸��� ���� �����ϸ� �ش� ������Ʈ�� 
         */
        this.ghpGauge = GameObject.Find("hpGauge");
        //this.GameOver = GameObject.Find("GameOver");
    }

    /*
     * ���߿� ȭ�� ��Ʈ�ѷ����� HP ������ ǥ�ø� ���̴� ó���� ȣ���� ���� �����
     * ȭ��� �÷��̾ �浹���� �� ȭ�� ��Ʈ�ѷ��� f_DecreaseHp() �޼��带 ȣ����
     * �޼����� ����� ȭ��� �÷��̾ �浹���� �� Image ������Ʈ(hpGauge)�� fillAmount�� �ٿ�
     * HP�������� ǥ���ϴ� ������ 10%�� ����
     */
    public void f_DecreaseHp()
    {
        /*
         * ����Ƽ ������Ʈ�� GameObjrct��� �� ���ڿ� ���� �ڷ�(���۳�Ʈ)�� �߰��ؼ� ����� Ȯ����
         * (��) ������Ʈ�� ���������� �����̰� �Ϸ��� Rigidbody ���۳�Ʈ �߰�
         * (��) �Ҹ��� ���� �Ϸ���AudioSource���۳�Ʈ �߰�
         * (��) ��ü ����� �ø��� �ʹٸ� ���۳�Ʈ�� �߰���
         * ���۳�Ʈ ���� ���: GetComponent�� ���� ������Ʈ�� ���� 'oo������Ʈ�� �ּ���'��� ��Ź�ϸ�
         * �ش�Ǵ� ���۳�Ʈ(���)�� �����ִ� �޼���
         * (��)AudioSource���۳�Ʈ�� ���ϸ� -> GetCommponent<)AudioSource>()
         * (��)Text���۳�Ʈ�� ���ϸ� ->  GetComponent<Text>()
         * (��) ���� ���� ��ũ��Ʈ�� ���۳�Ʈ�� �����̹Ƿ� GetComponent �޼��带 ����ؼ� ���� �� ����
         */

        //ȭ��� �÷��̾ �浹������ Image ������Ʈ(hpGauge)�� fillAmount�� �ٿ�
        this.ghpGauge.GetComponent<Image>().fillAmount -= 0.1f;

        if (this.ghpGauge.GetComponent<Image>().fillAmount <= 0)
        {
            GameOver();
        }
    }
    public void GameOver()
    {
        _isDead = true;
        _GameOver.SetActive(true);
        Time.timeScale = 0;
    }
    public void GameStart()
    {
        _isDead = false;
        Time.timeScale = 1;
    }
}
