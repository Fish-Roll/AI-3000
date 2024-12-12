using Features.AI;
using UnityEngine;
using UnityEngine.UI;

namespace Features.CommandField
{
    public class CommandFieldView : MonoBehaviour
    {
        [SerializeField] private GameObject _commandField;
        [SerializeField] private InputField _inputField;
        [SerializeField] private AIManager _aiManager;
        private CommandController _controller;
        
        private bool _isActive;

        private void Awake()
        {
            _controller = new CommandController();
            _controller.Init(_aiManager);
        }
        
        public void Handle()
        {
            if (_isActive)
            {
                _isActive = false;
                _controller.HandleCommand(_inputField.text);
                CloseField();
                
            }
            else
            {
                _isActive = true;
                OpenField();
            }
        }
        
        
        private void CloseField()
        {
            _commandField.SetActive(false);
        }

        private void OpenField()
        {
            _commandField.SetActive(true);
        }
    }
}