using UnityEngine;
using TMPro;

public class Scoreboard : MonoBehaviour
{
    [SerializeField] TMP_Text scoreText;

    int points = 0;
    public void IncreaseScore(int amount)
    {
        points += amount;
        scoreText.text = points.ToString();
    }
}
