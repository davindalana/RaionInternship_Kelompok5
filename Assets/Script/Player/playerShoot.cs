using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerShoot : MonoBehaviour
{
    public GameObject fireBall;
    public Transform shootPoint;

    void Update()
    {
        Shoot();
    }
    void Shoot()
    {

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Debug.Log(shootPoint.position);
            Instantiate(fireBall, shootPoint.position, transform.rotation);
        }
    }
}
