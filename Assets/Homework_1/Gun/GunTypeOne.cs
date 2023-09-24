using UnityEngine;

public class GunTypeOne : IShootable
{
    private int _bullet = 10;

    public void Shot()
    {
        if (_bullet > 0)
        {
            _bullet--;
            Debug.Log($"Выстрел 1 пулей, осталось {_bullet} патронов");
            return;
        }

        Debug.Log("Патроны закончились");
    }
}