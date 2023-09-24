using UnityEngine;

public class GunTypeThree : IShootable
{
    private int _bullet = 15;
    private int _amountBulletsPerShot = 3;

    public void Shot()
    {
        if (_bullet > 0)
        {
            _bullet -= _amountBulletsPerShot;
            Debug.Log($"Выстрел из {_amountBulletsPerShot} пуль, осталось {_bullet} патронов");
            return;
        }

        Debug.Log("Патроны закончились");
    }
}