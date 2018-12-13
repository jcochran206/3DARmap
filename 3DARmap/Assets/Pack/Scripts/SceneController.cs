using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour {

    public static string keyword;

	// Use this for initialization
	void Start () {
        Debug.Log(keyword);
	}

    public void askGoogle(string passedKeyword){
        keyword = passedKeyword;

    }

    public void changeScene(string scene){
        SceneManager.LoadSceneAsync(scene);
    }


    public void Quit() {
        Application.Quit();
    }

}
