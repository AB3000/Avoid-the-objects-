using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ButtonController : MonoBehaviour {


    bool isClicked = false;
    public string scene;
    //initialization

    public void Update()
    {          if (isClicked == true)
                {
                    StartCoroutine(LoadYourAsyncScene());
                    isClicked = false;
                }
    }


    public IEnumerator LoadYourAsyncScene()
    {
        // The Application loads the Scene in the background as the current Scene runs.
        // This is particularly good for creating loading screens.
        // You could also load the Scene by using sceneBuildIndex. In this case Scene2 has
        // a sceneBuildIndex of 1 as shown in Build Settings.

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(scene);

        // Wait until the asynchronous scene fully loads
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }


    public void change(){
        isClicked = true;
    }


}
