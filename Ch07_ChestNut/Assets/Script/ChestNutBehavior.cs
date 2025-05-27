using TMPro;
using UnityEngine;

public class ChestNutBehavior : MonoBehaviour
{

    public void Shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);
        GameManager.instance.isShoot = true;
        //쏘자마자 다시 쏘지 않기위한 Bool값
        Invoke("ShootOut", 6f);
        //6초 뒤에 다시 밤송이 쏘기 가능하게끔 함
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Application.targetFrameRate = 60;
        //Shoot(new Vector3(0, 200, -2000));


    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Target"))
        {
            GameManager.instance.isHit = true;
            GetComponent<Rigidbody>().isKinematic = true;
            GetComponent<ParticleSystem>().Play();
            GameManager.instance.score++;

        }
    }



    void ShootOut()
    {
        GameManager.instance.isShoot = false;
    }
}
