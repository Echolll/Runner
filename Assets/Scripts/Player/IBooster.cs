using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IBooster <T> where T : MonoBehaviour
{
    float AdditionalSpeed { get; }
    float BoostTime { get; }
    T Object { get; }
}
