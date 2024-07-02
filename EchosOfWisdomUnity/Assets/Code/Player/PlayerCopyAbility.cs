using UnityEngine;
using UnityEngine.InputSystem;

namespace Character
{
    public class PlayerCopyAbility : MonoBehaviour
    {
        #region MonoBehaviour Methods

        private void OnTriggerStay(Collider other)
        {
            if(other.GetComponent<ICopyable>()?.CanBeCopied() ?? false)
            {
                if(Keyboard.current.eKey.isPressed)
                    other.GetComponent<ICopyable>().SaveObject();
            }
        }
        
        #endregion
    }
}