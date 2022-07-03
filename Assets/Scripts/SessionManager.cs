using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SessionManager : MonoBehaviour
{
    public SessionData data;

    private void Awake()
    {
        Load();
        DontDestroyOnLoad(gameObject);
    }

    public void StartGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("main");
    }

    public void SetDataName(string name)
    {
        if (!data.Name.Equals(name))
        {
            data.Name = name;
            data.Score = 0;
        }
    }

    public void Save()
    {
        PlayerPrefs.SetString("Name", data.Name);
        PlayerPrefs.SetInt("Score", data.Score);
        PlayerPrefs.Save();
    }

    public void Load()
    {
        data.Name = PlayerPrefs.GetString("Name", "None");
        data.Score = PlayerPrefs.GetInt("Score", 0);
    }

    public void Quit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
        Application.Quit();
    }
}
