using Features.Locomotion;
using UnityEngine;

namespace Features.AI
{
    public class Pal : MonoBehaviour
    {
        [SerializeField] private string _name = "";
        [SerializeField] private Transform _player;
        private Movement _movement;

        private void Start()
        {
            _movement = GetComponent<Movement>();
        }
        
        public void Follow()
        {
            StartCoroutine(_movement.Move(_player.transform.position));
        }
    }
}