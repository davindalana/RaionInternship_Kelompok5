using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallBehavior : MonoBehaviour
{
    public float speed, damage, destroyTime;
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }
}
