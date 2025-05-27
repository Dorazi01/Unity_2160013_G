using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
public class Level : MonoBehaviour
    //�� �Ŵ����� �̿��� �� �̵� ��ȯ ��� Ŭ����
{
    public void LevelSelect()
    {
        SceneManager.LoadScene("LevelScene");
    }

    public void GameScene()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void Tutorial()
    {
        SceneManager.LoadScene("TutorialScene");
        GameManager.instance.throwChestNutNum = -1;
    }

    public void CountScene()
    {
        SceneManager.LoadScene("CountScene");
    }

}