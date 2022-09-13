using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    [SerializeField] private Rigidbody characterBody;
    [SerializeField] private float speed = 2f;

    private void Update()
    {
        if(Input.GetAxis("Horizontal") != 0)
        {
            transform.Translate(Vector3.right * Time.deltaTime * Input.GetAxis("Horizontal"));
        }
        if (Input.GetAxis("Vertical") != 0)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * Input.GetAxis("Vertical"));
        }

        if (Input.GetKey(KeyCode.Space))
            Jump();

    }

    private void Jump()
    {
        characterBody.AddForce(Vector3.up * 10f);
    }

}
