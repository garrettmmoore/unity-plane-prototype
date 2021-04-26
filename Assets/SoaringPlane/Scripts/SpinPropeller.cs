using UnityEngine;

namespace Challenge_1.Scripts
{
    public class SpinPropeller : MonoBehaviour
    {
        private const float RotationSpeed = 1000f;
        
        private void LateUpdate()
        {
            transform.Rotate(Vector3.forward * (Time.deltaTime * RotationSpeed));
        }
    }
}
