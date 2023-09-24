using UnityEngine;

public class SellVegetables : IState
{
    private float _minReputationForSellVegetables = 20;
    private float _maxReputationForSellVegetables = 50;

    public bool Sell(float reputation)
    {
        if (!(reputation >= _minReputationForSellVegetables) ||
            !(reputation <= _maxReputationForSellVegetables)) return false;
        Debug.Log("Вы можете купить овощи");
        return true;
    }
}