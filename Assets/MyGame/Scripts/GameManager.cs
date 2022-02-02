using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    private const string myScriptableObject = "ScriptableObjectNameData";
    private InputField userName;
    private TextMeshProUGUI tmpName;

    public SoNameData nameData;
    public SceneLoader sceneLoader;

    private void Start()
    {
        userName = FindObjectOfType<InputField>();
    }

    public void SaveName()
    {
        nameData.name = myScriptableObject;
        nameData.yourName = userName.text;
        sceneLoader.LoadNextScene();
    }

    public void LoadName()
    {
        if(tmpName == null)
        {
            tmpName = GameObject.Find("UiTxtmpNameInSo").GetComponent<TextMeshProUGUI>();
        }

        tmpName.text = nameData.yourName;
    }

    public void GoToScene(int index)
    {
        SceneManager.LoadScene(index);
    }
}
