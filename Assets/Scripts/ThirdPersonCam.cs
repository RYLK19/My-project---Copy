using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCam : MonoBehaviour
{
    [Header("References")]
    public Transform orientation;
    public Transform Player;
    public Transform PlayerObj;
    public Rigidbody rb;

    public float rotationSpeed;
    
    private void start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }



    private void Update()
    { 
    Vector3 viewDir = Player.position - new Vector3(transform.position.x, Player.position.y, transform.position.z);
    orientation.forward = viewDir.normalized;

        float horizontalInput = Input.GetAxis("Horizontal");
    float verticalInput = Input.GetAxis("Vertical");
    Vector3 inputDir = orientation.forward * verticalInput + orientation.right * horizontalInput;


    if(inputDir != Vector3.zero)
        PlayerObj.forward = Vector3.Slerp(PlayerObj.forward, inputDir.normalized, Time.deltaTime * rotationSpeed);

        
     }

}
