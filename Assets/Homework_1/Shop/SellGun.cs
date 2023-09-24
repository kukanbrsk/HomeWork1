using UnityEngine;

public class SellGun : IState
{
    private float _reputationForSellGun = 80;

    public bool Sell(float reputation)
    {
        if (!(reputation >= _reputationForSellGun)) return false;
        Debug.Log("Вы можете купить оружие");
        return true;

    }
}