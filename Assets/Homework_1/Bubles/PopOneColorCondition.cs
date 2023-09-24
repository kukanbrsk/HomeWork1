using System.Linq;
using UnityEngine;

public class PopOneColorCondition : GameWinCondition
{
    private GameProgressHandler _gameProgressHandler;
    private BallType _ballType;

    public PopOneColorCondition(GameProgressHandler gameProgressHandler, BallType ballType)
    {
        _gameProgressHandler = gameProgressHandler;
        _ballType = ballType;
    }

    public override bool CheckWinCondition()
    {
        if (_gameProgressHandler.Balls.Any(ball => ball.BallType == _ballType)) return false;

        Debug.Log($"Вы лопнули все шарики одного цвета {_ballType}");
        return true;
    }
}