using UnityEngine;

namespace SoaringPlane.Scripts
{
    public class FollowPlayer : MonoBehaviour
    {
        public GameObject plane;
        private readonly Vector3 _offset = new Vector3(50.0f, 5.2f, 2.6f);

        private void LateUpdate()
        {
            transform.position = plane.transform.position + _offset;
        }
    }
}