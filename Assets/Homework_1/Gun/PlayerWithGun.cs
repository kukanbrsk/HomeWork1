using UnityEngine;

public class PlayerWithGun : MonoBehaviour
{
    private IShootable _shootable;
    private int _counter = 0;

    private void SetTypeGun(IShootable shootable)
    {
        _shootable = shootable;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            SetTypeGun(ToggleWeapon());
            Debug.Log("Переключение оружия");
        }

        if (Input.GetMouseButtonUp(0))
        {
            TryShoot();
        }
    }

    private void TryShoot()
    {
        if (_shootable != null)
        {
            Shoot();
            return;
        }

        Debug.Log("Нет оружия, возьмите оружие на кнопку X");
    }

    private void Shoot()
    {
        _shootable?.Shot();
    }

    private IShootable ToggleWeapon()
    {
        var guns = new IShootable[]
        {
            new GunTypeOne(),
            new GunTypeTwo(),
            new GunTypeThree()
        };
        var currentGun = _counter;
        _counter = _counter == guns.Length - 1 ? 0 : _counter + 1;
        return guns[currentGun];
    }
}