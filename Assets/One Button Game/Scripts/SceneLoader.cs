using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void ExitGame()
    {
        //Exits the game when ran as a build executable.
        Application.Quit();

        //If the game is being ran inside of Unity Editor, this exits out of play mode instead.
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }

    public void Play() // When play button is pressed loads the game from first level
    {
        SceneManager.LoadScene("Level 1");
    }
}
