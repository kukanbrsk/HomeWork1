using UnityEngine;

public class PopAllBallsCondition : GameWinCondition
{
    private GameProgressHandler _gameProgressHandler;

    public PopAllBallsCondition(GameProgressHandler gameProgressHandler)
    {
        _gameProgressHandler = gameProgressHandler;
    }

    public override bool CheckWinCondition()
    {
        if (_gameProgressHandler.Balls.Count == 0)
        {
            Debug.Log("Вы лопнули все шарики");
        }

        return _gameProgressHandler.Balls.Count == 0;
    }
}