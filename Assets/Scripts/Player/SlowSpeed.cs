using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowSpeed : MonoBehaviour , ISlowing <MonoBehaviour>
{
    [SerializeField] private float _slowSpeed;
    [SerializeField] private float _slowingTime;
    public float SlowingSpeed => _slowSpeed;
    public float SlowingTime => _slowingTime;
    public MonoBehaviour Object => this;
}
