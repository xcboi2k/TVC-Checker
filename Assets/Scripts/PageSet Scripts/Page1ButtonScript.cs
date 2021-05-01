using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Page1ButtonScript : MonoBehaviour
{
    private const string selectedFigure = "Selected Figure";

    public void Dengar_Button(){
        PlayerPrefs.SetInt(selectedFigure, 1);
        SceneManager.LoadScene("ViewingScene");
    }

    public void HothLeia_Button(){
        PlayerPrefs.SetInt(selectedFigure, 2);
        SceneManager.LoadScene("ViewingScene");
    }

    public void HanSoloEcho_Button(){
        PlayerPrefs.SetInt(selectedFigure, 3);
        SceneManager.LoadScene("ViewingScene");
    }

    public void LukeBespin_Button(){
        PlayerPrefs.SetInt(selectedFigure, 4);
        SceneManager.LoadScene("ViewingScene");
    }

    public void ATATComm_Button(){
        PlayerPrefs.SetInt(selectedFigure, 5);
        SceneManager.LoadScene("ViewingScene");
    }

    public void C3PO_Button(){
        PlayerPrefs.SetInt(selectedFigure, 6);
        SceneManager.LoadScene("ViewingScene");
    }

    public void DakRalter_Button(){
        PlayerPrefs.SetInt(selectedFigure, 7);
        SceneManager.LoadScene("ViewingScene");
    }

    public void Vader_Button(){
        PlayerPrefs.SetInt(selectedFigure, 8);
        SceneManager.LoadScene("ViewingScene");
    }

    public void Boba_Button(){
        PlayerPrefs.SetInt(selectedFigure, 9);
        SceneManager.LoadScene("ViewingScene");
    }

    public void LOM_Button(){
        PlayerPrefs.SetInt(selectedFigure, 10);
        SceneManager.LoadScene("ViewingScene");
    }

    public void CCPilot_Button(){
        PlayerPrefs.SetInt(selectedFigure, 11);
        SceneManager.LoadScene("ViewingScene");
    }

    public void SidiousROTS_Button(){
        PlayerPrefs.SetInt(selectedFigure, 12);
        SceneManager.LoadScene("ViewingScene");
    }
}
