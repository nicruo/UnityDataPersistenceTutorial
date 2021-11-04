using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

#if UNITY_EDITOR
using UnityEditor;
#endif

[DefaultExecutionOrder(1000)]
public class MenuUIHandler : MonoBehaviour
{
    public TextMeshProUGUI bestText;
    public TMP_InputField usernameInputField;
    // Start is called before the first frame update
    void Start()
    {
        bestText.text = DataManager.Instance.HighScoreText;
    }

    public void StartNew()
    {
        DataManager.Instance.Username = usernameInputField.text;
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        //MainManager.Instance.SaveColor();
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
