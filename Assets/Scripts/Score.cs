using TMPro;
using UnityEngine;

public class Score
{
    private int score;

    public void UpdateScore(int score)
    {
        this.score += score;
    }

    public int Scores
    {
        get => score;
    }
}