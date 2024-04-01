using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Player : MonoBehaviour
{
    [SerializeField][Range(0, 100)] private float _moveSpeed = 1;
    [SerializeField][Range(2, 100)] private float _jumpForce = 2;
    
    private Vector3 _montion;
    private bool isGrounded;
    private string _input;
    Rigidbody rb;

    void Start()
    {
        rb= GetComponent<Rigidbody>();
        _montion = new Vector3(0,2f,0);

#if UNITY_EDITOR
        _input = "Editor";
#elif UNITY_STANDALONE_WIN
        _input = "Windows";
#endif
    }

    private void OnCollisionStay()
    {
        isGrounded = true;
    }

    void Update()
    {        
        transform.Translate(transform.forward * Time.deltaTime * _moveSpeed);

        float standaloneX = Input.GetAxis(_input) * Time.deltaTime * _moveSpeed;
        transform.position += new Vector3(standaloneX, 0, 0);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded) 
        { 
            Jump(); 
        }
        
    }

    public void BoostSpeed(float additionalSpeed ,float boostTime)
    {
        StartCoroutine(BoostingSpeed(additionalSpeed, boostTime));
    }

    private IEnumerator BoostingSpeed (float additionalSpeed, float boostTime)
    {
        _moveSpeed += additionalSpeed;
        yield return new WaitForSeconds(boostTime);
        _moveSpeed -= additionalSpeed;
    }

    public void SlowSpeed(float SlowingSpeed,float SlowingTime)
    {
        StartCoroutine(SlowingCoroutine(SlowingSpeed, SlowingTime));
    }

    private IEnumerator SlowingCoroutine (float SlowingSpeed, float SlowingTime)
    {
        _moveSpeed -= SlowingSpeed;
        yield return new WaitForSeconds(SlowingTime);
        _moveSpeed += SlowingSpeed;
    }

    private void Jump()
    {
        rb.AddForce(_montion * _jumpForce, ForceMode.Impulse);
        isGrounded = false;
    }

    
}
