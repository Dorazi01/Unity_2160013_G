using Unity.VisualScripting;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour
{
    public enum InfoType { Score, Count, Power, GameOver }
    public InfoType type;

    public TMP_InputField countInputField; // InputField ����
    public Button setCountButton; // �Է°��� ������ ��ư

    TMP_Text myText;
    Slider mySlider;



    void Awake()
    {

        myText = GetComponent<TMP_Text>();
        mySlider = GetComponent<Slider>();
    }


    void Start()
    {
        // ��ư Ŭ�� �� OnSetCountClicked �Լ� ����
        if (setCountButton != null)
            setCountButton.onClick.AddListener(OnSetCountClicked);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        switch (type)
        {
            case InfoType.Score:

                myText.text = string.Format("Score : {0:F0}", GameManager.instance.score * 10);

                if (!GameManager.instance.isLive)
                {
                    gameObject.SetActive(false);
                }
                break;
            case InfoType.Count:
                myText.text = string.Format("Count : {0:F0}", GameManager.instance.throwChestNutNum);
                if (!GameManager.instance.isLive)
                {
                    gameObject.SetActive(false);
                }

                break;
            case InfoType.Power:

                break;
            case InfoType.GameOver:

                myText.text = string.Format("Final Score : {0:F0}", GameManager.instance.score * 10);

                break;
        }

    }
    public void OnSetCountClicked()
    {
        if (int.TryParse(countInputField.text, out int count) && count > 0)
        {
            PlayerPrefs.SetInt("ThrowCount", count);  // ���� Ƚ���� ����
            PlayerPrefs.Save();

            // �� �̵�
            SceneManager.LoadScene("GameScene");
        }
    }
}
