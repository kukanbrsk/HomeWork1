using System.Linq;
using UnityEngine;

public class Shop : MonoBehaviour
{
    private IState[] _availableStates = new IState[]
    {
        new SellArm(),
        new SellGun(),
        new SellVegetables()
    };

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Player player))
        {
            Sell(player);
        }
    }

    private void Sell(Player player)
    {
        if (_availableStates.Any(state => state.Sell(player.Reputation))) return;

        Debug.Log("У вас недостаточно репутации для покупки товаров.");
    }
}