using UnityEngine;
using System;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] int _healthPoint;
    private int _maxHealth;

    public event Action PlayerDeath;
       
    private void Awake()
    {
        _maxHealth = _healthPoint;
    }

    public int HealthPoint
    {
        get { return _healthPoint; }
    }

    public void TakeDamage(int damage)
    {
        _healthPoint = Mathf.Clamp(_healthPoint - damage, 0, _maxHealth);
 
        if(_healthPoint == 0)
        {
            PlayerDeath?.Invoke();
            Debug.Log("You died!");                 
        }
        else 
        { 
            Debug.Log($"You take damage!Your health = {_healthPoint}"); 
        }
    }
}
