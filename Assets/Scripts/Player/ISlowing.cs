using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISlowing <T> where T : MonoBehaviour
{
   float SlowingSpeed { get; }
   float SlowingTime { get; }
   T Object { get; }
}
