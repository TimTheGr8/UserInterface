using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cannon : MonoBehaviour
{
    [SerializeField]
    private GameObject _bullet;
    [SerializeField]
    private GameObject _bulletStartPosition;
    [SerializeField]
    private float _bulletForce = 300;


    public void Fire()
    {
        GameObject projectile = Instantiate(_bullet, _bulletStartPosition.transform.position, _bulletStartPosition.transform.rotation);
        var rb = projectile.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.AddRelativeForce(new Vector3(0, 0, -_bulletForce));
        }
    }

    public void LeftTurn()
    {
        transform.Rotate(0, -15, 0);
    }

    public void RightTurn()
    {
        transform.Rotate(0, 15, 0);
    }
}
