using Features.CommandField;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Features.InputSystem
{
    public class InputHandler : MonoBehaviour
    {
        private InputSystemActions _inputSystemActions;
        private CommandFieldView _commandFieldView;
        
        private void Awake()
        {
            _inputSystemActions = new InputSystemActions();
            _commandFieldView = FindFirstObjectByType<CommandFieldView>();
        }

        private void Start()
        {
            _inputSystemActions.Keyboard.EnterComandField.started += EnterCommandFieldOnStarted;
        }

        private void EnterCommandFieldOnStarted(InputAction.CallbackContext obj)
        {
            _commandFieldView.Handle();
        }

        
        private void OnEnable()
        {
            _inputSystemActions.Enable();
        }

        private void OnDisable()
        {
            _inputSystemActions.Disable();
        }
    }
}