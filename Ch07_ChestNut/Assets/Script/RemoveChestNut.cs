using UnityEngine;

public class RemoveChestNut : MonoBehaviour
{
    SphereCollider Sc;

    void Start()
    {
        Sc = GetComponent<SphereCollider>();
    }

    void Update()
    {
       
    }


     private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Floor") //�浹�� ������Ʈ�� �ٴ��� ���
        {
            Destroy(gameObject,1); //����̸� ����
        }

        if (collision.gameObject.tag == "MovingWall") //�浹�� ������Ʈ�� �ٴ��� ���
        {
            
            Sc.enabled = false;
        }
    }
        

    }
   

