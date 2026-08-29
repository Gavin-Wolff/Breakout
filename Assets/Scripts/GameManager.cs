using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int score;
    public Scoring scoring;
    public Ball ball;
    public TileSpawner tileSpawner;
    public HelpMenu helpMenu;

    private void Start()
    {
        score = 0;
        scoring.SetScore(score);
    }

    public void AddScore(int points)
    {
        score += points;
        scoring.SetScore(score);
    }

    public void LoseGame()
    {
        score = 0;
        scoring.SetScore(score);

        ball.ResetBall();
        tileSpawner.ResetTiles();

        helpMenu.OpenHelp();
    }
}