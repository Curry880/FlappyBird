using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    [SerializeField] TextMeshProUGUI scoreText; // �X�R�A��\������UI�e�L�X�g
    private int score = 0;

    void Awake()
    {
        // �V���O���g���p�^�[���̎���
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
        UpdateScoreText();
    }

    public void AddScore(int value)
    {
        score += value;
        UpdateScoreText();
    }

    void UpdateScoreText()
    {
        //scoreText.text = "Score: " + score.ToString();
        scoreText.SetText($"Score: {score.ToString()}");
    }
}
