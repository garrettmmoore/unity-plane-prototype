using UnityEngine;

namespace Challenge_1.Scripts
{
    public class PlayerController : MonoBehaviour
    {
        private const float ConstantSpeed = 10f;
        private const float Speed = 20f;
        private const float RotationSpeed = 80f;
        private float _verticalInput;
        private float _horizontalInput;

        private void FixedUpdate()
        {
            _verticalInput = Input.GetAxis("Vertical");
            _horizontalInput = Input.GetAxis("Horizontal");

            // move the plane forward at a constant rate
            transform.Translate(Vector3.forward * (Time.deltaTime * ConstantSpeed));
            
            // increase the plane's forward speed on left/right arrow keys
            transform.Translate(Vector3.forward * (Time.deltaTime * Speed * _horizontalInput));

            // tilt the plane up/down based on up/down arrow keys
            transform.Rotate(Vector3.left * (Time.deltaTime * RotationSpeed * _verticalInput));
        }
    }
}