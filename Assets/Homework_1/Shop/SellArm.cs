using UnityEngine;

public class SellArm : IState
{
    private float _minReputationForSellArm = 50;
    private float _maxReputationForSellArm = 80;

    public bool Sell(float reputation)
    {
        if (!(reputation >= _minReputationForSellArm) || !(reputation <= _maxReputationForSellArm)) return false;
        Debug.Log("Вы можете купить броню");
        return true;
    }
}