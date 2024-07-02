using UnityEngine;

/// <summary>
/// Class to define a copyable object.
/// </summary>
public class CopyableObject : MonoBehaviour, ICopyable
{
    #region Private Attributes

    public ParticleSystem _particleSystem;

    private bool _isSaved = false;
    
    #endregion

    #region Events    
    #endregion

    #region MonoBehaviour Methods

    private void Awake()
    {
        SetParticleState();
    }
     
    #endregion

    #region Methods

    private void SetParticleState()
    {
        if (_isSaved)
        {
            _particleSystem.Stop();
        }
        else
        {
            _particleSystem.Play();
        }
    }
    
    #endregion
    
    #region Interface

    /// <summary>
    /// Method to check if the object is in range. Inherited from ICopyable interface.
    /// </summary>
    public bool IsInRange()
    {
        return false;
    }

    /// <summary>
    /// Method to check if the object can be copied. Inherited from ICopyable interface.
    /// </summary>
    public bool CanBeCopied()
    {
        return !_isSaved;
    }

    /// <summary>
    /// Method to save the object. Inherited from ICopyable interface.
    /// </summary>
    public void SaveObject()
    {
        _isSaved = true;
        SetParticleState();
        Debug.Log("Object saved!");
    }

    #endregion
}