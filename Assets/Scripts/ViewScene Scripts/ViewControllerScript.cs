using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ViewControllerScript : MonoBehaviour
{
    private const string selectedFigure = "Selected Figure";

    public void BackToMenu(){
        PlayerPrefs.SetInt(selectedFigure, 0);
        SceneManager.LoadScene("MenuScene");
    }
}
