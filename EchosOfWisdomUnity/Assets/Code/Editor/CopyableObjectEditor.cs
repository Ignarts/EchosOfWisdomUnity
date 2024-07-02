using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(CopyableObject), true)]
public class CopyableObjectEditor : Editor
{
    #region Attributes

    private SerializedProperty _particleSystem;
    
    #endregion

    #region Editor Methods

    private void OnEnable()
    {
        _particleSystem = serializedObject.FindProperty("_particleSystem");
    }

    public override void OnInspectorGUI()
    {
        serializedObject.Update();

        EditorGUILayout.PropertyField(_particleSystem, new GUIContent("Particle System"));

        if (GUILayout.Button("Save"))
        {
            // Llama al método Save del CopyableObject
            (target as CopyableObject)?.SaveObject();
        }

        serializedObject.ApplyModifiedProperties();
    }
    
    #endregion
}