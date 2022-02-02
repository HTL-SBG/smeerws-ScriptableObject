using UnityEngine;

[CreateAssetMenu(menuName = "SoNameData")]
public class SoNameData : ScriptableObject, ISerializationCallbackReceiver 
{
    public string yourName;

    public void OnAfterDeserialize()
    {
        yourName = "empty";
    }

    public void OnBeforeSerialize(){ }
       
}
