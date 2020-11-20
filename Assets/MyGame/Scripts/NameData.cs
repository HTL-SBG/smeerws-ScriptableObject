using UnityEngine;

[CreateAssetMenu(menuName = "NameData")]
public class NameData : ScriptableObject, ISerializationCallbackReceiver 
{
    public string yourName;

    public void OnAfterDeserialize()
    {
        yourName = "empty";
    }

    public void OnBeforeSerialize(){ }
       
}
