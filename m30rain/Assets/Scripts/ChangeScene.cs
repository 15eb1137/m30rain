using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    void Start()
    {
        Invoke("ChangeSceneToTitle", 100);        
    }
    void ChangeSceneToTitle() {
        SceneManager.LoadScene("TitleScene");
    }
}
