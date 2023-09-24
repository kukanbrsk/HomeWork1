using System.Collections.Generic;
using UnityEngine;

public class GameProgressHandler : MonoBehaviour
{
    [SerializeField] private List<Ball> balls;
    [SerializeField] private BallType ballType;

    private GameWinCondition _gameWinCondition;
    private GameType _currentGameType;

    public List<Ball> Balls => balls;

    public void CheckWinCondition()
    {
        _gameWinCondition.CheckWinCondition();
    }

    public void OnPopAllBallsButtonClick()
    {
        _currentGameType = GameType.PopAllBalls;
        UpdateGameWinCondition();
    }

    public void OnPopOneColorButtonClick()
    {
        _currentGameType = GameType.PopOneColor;
        UpdateGameWinCondition();
    }

    private void UpdateGameWinCondition()
    {
        _gameWinCondition = _currentGameType switch
        {
            GameType.PopAllBalls => new PopAllBallsCondition(this),
            GameType.PopOneColor => new PopOneColorCondition(this, ballType),
            _ => _gameWinCondition
        };
    }

    public void RemoveBall(Ball ball)
    {
        balls.Remove(ball);
    }

    [ContextMenu("FindBalls")]
    private void FindBalls()
    {
        balls.AddRange(FindObjectsOfType<Ball>());
    }
}

public enum GameType
{
    PopAllBalls,
    PopOneColor
}