using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float forwardSpeed;
    [SerializeField] private float sidewaySpeed;

    private void Update()
    {
        var horizontalInput = Input.GetAxis("Horizontal");
        Movement();
    }
    private void Movement() 
    {
        transform.position += Vector3.forward * forwardSpeed * Time.deltaTime;
    }
}
