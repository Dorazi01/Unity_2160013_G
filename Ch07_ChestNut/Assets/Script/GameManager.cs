using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class GameManager : MonoBehaviour
{

    //���� ���� ��ȣ�ۿ� ���ӿ�����Ʈ ����
    public static GameManager instance;

    public GameObject tutorialWall1;
    public GameObject tutorialWall2;

    public GameObject finalScoreText;
    public GameObject retryButton;
    public GameObject mainMenuButton;
    public GameObject powerSlider;
    public GameObject powerText;

    // ���� ���࿡ �ʿ��� ������
    public int throwChestNutNum = 0;

    public int score = 0;
    public bool isShoot = false;
    public bool isHit = false;

    public bool isLive = true;


    

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

       

    }


    void Start()
    {
        throwChestNutNum = PlayerPrefs.GetInt("ThrowCount", 0);  // ����� �� �ҷ�����
        //�÷��̾ ���Ƿ� ���� ����� ������ Ƚ�� PlayerPreference�� �ҷ�����
    }

    void Update()
    {

        if (throwChestNutNum == 0)
        {
            Invoke("GameOver", 3f);
        }
        //���̻� ���� ����̰� ���� �� ���ӿ��� ���
    }

    void GameOver()
    {
        isLive = false;
        SceneManager.LoadScene("GameOverScene");
    }

    //�� �Ŵ�����Ʈ�� ���� �� �̵� ����
    public void EnableWall1()
    {
        tutorialWall1.SetActive(true);
    }

    public void EnableWall2()
    {
        tutorialWall2.SetActive(true);
    }

    public void DisableWall1()
    {
        tutorialWall1.SetActive(false);
    }

    public void DisableWall2()
    {
        tutorialWall2.SetActive(false);
    }

    public void RetryFun()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void MainMenuFun()
    {
        SceneManager.LoadScene("LevelScene");
    }


    
}
