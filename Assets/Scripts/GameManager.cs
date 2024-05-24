using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro; // TextMeshPro���g���ꍇ

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public TextMeshProUGUI gameOverText; // TextMeshPro���g���ꍇ
    private bool isGameOver = false;

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
        gameOverText.gameObject.SetActive(false); // �Q�[���J�n����GameOver���b�Z�[�W���\���ɂ���
    }

    private void Update()
    {
        if(isGameOver && Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("ResultScene");
        }
    }

    public void GameOver()
    {
        isGameOver = true;
        gameOverText.gameObject.SetActive(true); // GameOver���b�Z�[�W��\������
    }

    public bool IsGameOver()
    {
        return isGameOver;
    }
}

