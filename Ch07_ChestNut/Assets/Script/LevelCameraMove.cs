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
        //점수가 3의 배수일때만 카메라가 움직이도록 설정
        CameraLevel();


        //밤송이가 과녁에 맞았을 때 과녁쪽으로 카메라가 줌인, 줌아웃 되도록 설정
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



    //레벨 디자인으로 임의의 점수마다 카메라가 움직이도록 + isCameraMove를 사용해 한번 움직였으면 더이상 움직이지 않게 설정
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
