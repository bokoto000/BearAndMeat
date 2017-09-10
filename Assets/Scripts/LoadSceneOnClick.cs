using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadSceneOnClick : MonoBehaviour
{

    public void Click()
    {
        SceneManager.LoadScene("scene1");
    }
}