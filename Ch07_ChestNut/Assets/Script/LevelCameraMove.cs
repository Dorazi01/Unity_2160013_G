using System.Collections;
using NUnit.Framework.Constraints;
using UnityEngine;

public class LevelCameraMove : MonoBehaviour
{
    bool isCameraMove = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    

    // Update is called once per frame
    void Update()
    {

        //������ 3�� ����� �ƴҰ�� ī�޶��̵� X
        if (GameManager.instance.score % 3 != 0)
        {
            isCameraMove = false;
        }
        CameraLevel();

        if (GameManager.instance.isHit)
        {
            Vector3 tempPos = this.transform.position;
            StartCoroutine(HitCamMove(tempPos));
        }




    }



    //����̰� Ÿ�Ͽ� �浹�� ī�޶� ���� �޼���
    IEnumerator HitCamMove(Vector3 temp)
    {
        GameManager.instance.isHit = false;

        yield return new WaitForSeconds(1f);

        transform.position = new Vector3(transform.position.x, transform.position.y, 420f);

        yield return new WaitForSeconds(3f);
        transform.position = temp;


        yield return null;

    }



    //���������ο� ī�޶� ��ġ �̵� �޼���
    void CameraLevel()
    {
        if (GameManager.instance.score == 3 && !isCameraMove)
        {
            transform.Translate(0, 0, -7f);
            isCameraMove = true;
        }
        else if (GameManager.instance.score == 6 && !isCameraMove)
        {
            transform.Translate(0, 0, -7f);
            isCameraMove = true;
        }
        else if (GameManager.instance.score == 9 && !isCameraMove)
        {
            transform.Translate(0, 0, -7f);
            isCameraMove = true;
        }
        else if (GameManager.instance.score == 12 && !isCameraMove)
        {
            transform.Translate(0, 0, -7f);
            isCameraMove = true;
        }
        else if (GameManager.instance.score == 15 && !isCameraMove)
        {
            transform.Translate(0, 0, -7f);
            isCameraMove = true;
        }
        else if (GameManager.instance.score == 18 && !isCameraMove)
        {
            transform.Translate(0, 0, -7f);
            isCameraMove = true;
        }
        else if (GameManager.instance.score == 21 && !isCameraMove)
        {
            transform.Translate(0, 0, -7f);
            isCameraMove = true;
        }
        else if (GameManager.instance.score == 24 && !isCameraMove)
        {
            transform.Translate(0, 0, -7f);
            isCameraMove = true;
        }
        else if (GameManager.instance.score == 27 && !isCameraMove)
        {
            transform.Translate(0, 0, -7f);
            isCameraMove = true;
        }
        else if (GameManager.instance.score == 30 && !isCameraMove)
        {
            transform.Translate(0, 0, -7f);
            isCameraMove = true;
        }
    }
}
