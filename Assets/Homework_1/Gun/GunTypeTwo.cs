using UnityEngine;

public class GunTypeTwo : IShootable
{
    public void Shot()
    {
        Debug.Log("Выстрел 1 пулей, осталось бесконечно много патронов");
    }
}