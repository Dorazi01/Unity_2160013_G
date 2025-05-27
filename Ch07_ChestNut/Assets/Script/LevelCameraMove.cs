using System.Collections;
using NUnit.Framework.Constraints;
using UnityEngine;

public class LevelCameraMove : MonoBehaviour
{
    bool isCameraMove = false;
    
    
    // Update is called once per frame
    void Update()
    {

        if (GameManager.instance.score % 3 != 0)
        {
            isCameraMove = false;
        }
        //������ 3�� ����϶��� ī�޶� �����̵��� ����
        CameraLevel();


        //����̰� ���ῡ �¾��� �� ���������� ī�޶� ����, �ܾƿ� �ǵ��� ����
        if (GameManager.instance.isHit)
        {
            Vector3 tempPos = this.transform.position;
            StartCoroutine(HitCamMove(tempPos));
        }




    }




    IEnumerator HitCamMove(Vector3 temp)
    {
        GameManager.instance.isHit = false;

        yield return new WaitForSeconds(1f);

        transform.position = new Vector3(transform.position.x, transform.position.y, 420f);

        yield return new WaitForSeconds(3f);
        transform.position = temp;


        yield return null;

    }



    //���� ���������� ������ �������� ī�޶� �����̵��� + isCameraMove�� ����� �ѹ� ���������� ���̻� �������� �ʰ� ����
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
