using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTest_01 : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed = 5f;
    
    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(horizontalInput, 0f, verticalInput).normalized;

        if (moveDirection != Vector3.zero)
        {
            float targetAngle = Mathf.Atan2(moveDirection.x, moveDirection.z) * Mathf.Rad2Deg;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);
            
            Vector3 moveVector = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            transform.Translate(moveVector.normalized * moveSpeed * Time.deltaTime, Space.World);
        }
    }
    private float turnSmoothTime = 0.1f;
    private float turnSmoothVelocity;
}
