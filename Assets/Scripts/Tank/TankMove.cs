using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMove : MonoBehaviour
{
    [SerializeField] private VariableJoystick joystick;
    [SerializeField] private Rigidbody rigidbody;
    [SerializeField] private float speed;
    private void Awake()
    {
        if(joystick==null)
        {
            joystick = GameObject.FindGameObjectWithTag("Joystick").GetComponent<VariableJoystick>();
        }
        if (rigidbody==null)
        {
            rigidbody = GetComponent<Rigidbody>();
        }
    }
    private void FixedUpdate()
    {
        if (Input.GetAxis("Horizontal") != 0)
        {
            Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
            rigidbody.velocity = movement * speed * Time.fixedDeltaTime;

        }
        else
        {
            Vector3 movement = new Vector3(joystick.Horizontal, 0f, 0f);
            rigidbody.velocity = movement * speed * Time.fixedDeltaTime;
        }
        
    }
}
