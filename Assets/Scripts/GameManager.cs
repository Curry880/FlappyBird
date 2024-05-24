using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro; // TextMeshProを使う場合

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public TextMeshProUGUI gameOverText; // TextMeshProを使う場合
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
        gameOverText.gameObject.SetActive(false); // ゲーム開始時にGameOverメッセージを非表示にする
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
        gameOverText.gameObject.SetActive(true); // GameOverメッセージを表示する
    }

    public bool IsGameOver()
    {
        return isGameOver;
    }
}

