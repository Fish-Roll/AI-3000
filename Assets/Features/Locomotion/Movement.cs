using System.Collections;
using UnityEngine;

namespace Features.Locomotion
{
    public class Movement : MonoBehaviour
    {
        [SerializeField] private float _speed;
        

        private void Awake()
        {
            
        }
        
        public IEnumerator Move(Vector3 endPoint)
        {
            float time = 0;
            Vector3 startPos = transform.position;
            startPos.y = 0;
            endPoint.y = 0;
            while (Vector3.Distance(transform.position, endPoint) > 0.2f)
            {
                transform.position = Vector3.Lerp(startPos, endPoint, time);
                time += Time.deltaTime * _speed;
                yield return new WaitForEndOfFrame();
            }
        }
    }
}