using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    private TextMeshProUGUI scoreText;

    private void Awake()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateScore(int score)
    {
        int Gly = score;
        scoreText.text = $"Level: {score + Gly}";
    }
}