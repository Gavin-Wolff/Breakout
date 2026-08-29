using UnityEngine;
using TMPro;
public class Scoring : MonoBehaviour
{
public TextMeshProUGUI scoreText;


public void SetScore(int score)
{
scoreText.text = score.ToString();
}

}