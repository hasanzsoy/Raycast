using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Movement Settings")]
    [SerializeField] private float forwardSpeed;
    [SerializeField] private float sidewaySpeed;

    [Header("Clamp Settings")]
    [SerializeField] private float maxX;
    [SerializeField] private float minX;
    
    
    private void Update()
    {
        var horizontalInput = Input.GetAxis("Horizontal");
        Movement();
        SidewayMovement(horizontalInput);
        ClampPosition();
    }
    private void Movement() 
    {
        transform.position += Vector3.forward * forwardSpeed * Time.deltaTime;
    }
    private void SidewayMovement(float horizontalInput)
    {
        transform.position += Vector3.right * horizontalInput * sidewaySpeed * Time.deltaTime;
    }
    private void ClampPosition()
    { 
        Vector3 clampedPosition = transform.position;
        clampedPosition.x = Mathf.Clamp(clampedPosition.x, minX, maxX);
        transform.position = clampedPosition;
    }
}
