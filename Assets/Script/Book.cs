// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class Book : MonoBehaviour
// {
//     // [SerializeField] private WeaponInfo weaponInfo;
//     [SerializeField] private GameObject firePrefab;
//     [SerializeField] private Transform fireSpawn;
//     readonly int FIRE_HASH = Animator.StringToHash("Fire");

//     private Animator myAnimator;

//     private void Awake()
//     {
//         myAnimator = GetComponent<Animator>();
//     }

//     public void Attack()
//     {
//         myAnimator.SetTrigger(FIRE_HASH);
//         GameObject newArrow = Instantiate(firePrefab, fireSpawn.position, transform.rotation);
//     }

//     // public WeaponInfo GetWeaponInfo()
//     // {
//     //     return weaponInfo;
//     // }
// }