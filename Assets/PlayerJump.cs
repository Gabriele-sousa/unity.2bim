using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    [RequireComponent(typeof(Rigidbody))]
    public class PlayerJump : MonoBehaviour 
    {
        public float jumpForce = 3.0f;

        public float mass = 3.0f;

        private Rigidbody rigidbody;

        private bool isGround = false;
  
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();

        rigidbody.mass = mass;
    }

    // Update is called once per frame
    void Update()
    {
      if(!Input.GetKeyDown(KeyCode.Space) || !isGround) 
      return;

      rigidbody.AddForce(
        Vector3.up * jumpForce,
        ForceMode.Impulse
      );
    }

    void OnCollisionEnter(Collision collision)
    {
        isGround = true;
    }

    void OnCollisionExit(Collision collision)
    {
        isGround = false;
    }
    }
