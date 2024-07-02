using UnityEngine;
using UnityEngine.InputSystem;

namespace Character
{
    /// <summary>
    /// Class to handle the character movement.
    /// </summary>
    public class CharacterMovement : MonoBehaviour
    {
        #region Private Attributes

        [SerializeField] private Rigidbody _rigidbody;
        [SerializeField] private float _speed = 8.0f;

        private Vector3 _movementInput;
        
        #endregion

        #region MonoBehaviour Methods

        private void Update()
        {
            _movementInput = GetMovementInput();
        }
        
        private void FixedUpdate()
        {
            _rigidbody.MovePosition(_rigidbody.position + _movementInput.normalized * _speed * Time.fixedDeltaTime);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Method to get the movement input from the player.
        /// </summary>
        /// <returns></returns>
        private Vector3 GetMovementInput()
        {
            Keyboard _keyboard = Keyboard.current;
            
            float xInputValue = _keyboard.dKey.ReadValue() - _keyboard.aKey.ReadValue();
            float zInputValue = _keyboard.wKey.ReadValue() - _keyboard.sKey.ReadValue();

            return new Vector3(xInputValue, 0.0f, zInputValue);
        }
        
        #endregion
    }
}
