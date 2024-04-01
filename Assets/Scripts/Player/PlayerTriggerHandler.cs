using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerTriggerHandler : MonoBehaviour
{
    [SerializeField] private PlayerHealth _playerHealth;
    [SerializeField] private Player _player;

    private void OnTriggerEnter(Collider other)
    {
        if(other == null)
        {
            Debug.Log("Не удалось получить коллизию объета после столкновения!");
        }

        if(other.gameObject.TryGetComponent(out Obstacle obstacle))
        {
            _playerHealth.TakeDamage(obstacle.Damage);
            obstacle.gameObject.SetActive(false);
        }

        if(other.gameObject.TryGetComponent(out IBooster <MonoBehaviour> booster))
        {
            _player.BoostSpeed(booster.AdditionalSpeed, booster.BoostTime);
            booster.Object.gameObject.SetActive(false) ;
        }

        if(other.gameObject.TryGetComponent(out ISlowing<MonoBehaviour> slowing))
        {
            _player.SlowSpeed(slowing.SlowingSpeed, slowing.SlowingTime);
        }
    }

}
