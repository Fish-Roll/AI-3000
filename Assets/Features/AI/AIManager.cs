using System.Collections.Generic;
using UnityEngine;

namespace Features.AI
{
    public class AIManager : MonoBehaviour
    {
        [SerializeField] private List<Pal> _pals;

        public void Follow()
        {
            foreach (var pal in _pals)
            {
                pal.Follow();
            }
        }

        public void Here()
        {
            foreach (var pal in _pals)
            {
                pal.Follow();
            }
        }

        public void Stop()
        {
            foreach (var pal in _pals)
            {
                pal.Follow();
            }
        }

        public void Down()
        {
            foreach (var pal in _pals)
            {
                pal.Follow();
            }
        }

        public void Push()
        {
            foreach (var pal in _pals)
            {
                pal.Follow();
            }
        }
    }
}