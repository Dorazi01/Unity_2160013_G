using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class GameManager : MonoBehaviour
{

    //게임 전반 상호작용 게임오브젝트 나열
    public static GameManager instance;

    public GameObject tutorialWall1;
    public GameObject tutorialWall2;

    public GameObject finalScoreText;
    public GameObject retryButton;
    public GameObject mainMenuButton;
    public GameObject powerSlider;
    public GameObject powerText;

    // 게임 진행에 필요한 변수들
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
        throwChestNutNum = PlayerPrefs.GetInt("ThrowCount", 0);  // 저장된 값 불러오기
        //플레이어가 임의로 정한 밤송이 던지기 횟수 PlayerPreference로 불러오기
    }

    void Update()
    {

        if (throwChestNutNum == 0)
        {
            Invoke("GameOver", 3f);
        }
        //더이상 던질 밤송이가 없을 때 게임오버 출력
    }

    void GameOver()
    {
        isLive = false;
        SceneManager.LoadScene("GameOverScene");
    }

    //씬 매니지먼트를 통한 씬 이동 구현
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
