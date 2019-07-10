using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {
    public enum SceneName
    {
        Titel,
        Game
    }
    [SerializeField]
    private SceneName m_SceneName;
	void Start () {
		
	}
	
	void Update () {
		
	}
    public void ChangeScene()
    {
        SceneManager.LoadScene(m_SceneName.ToString());
    }
}
