using TMPro;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _scoreText;

    private int _score = 0;

    private void Start()
    {
        UpdateScore();
    }

    private void AddScore()
    {
        _score++;
        UpdateScore();
    }

    private void UpdateScore()
    {
        _scoreText.text = _score.ToString();
    }

    private void OnEnable()
    {
        Coin.CoinPickedUp += AddScore;
    }

    private void OnDisable()
    {
        Coin.CoinPickedUp -= AddScore;
    }
}