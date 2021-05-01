using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PictureViewScript : MonoBehaviour
{
    private const string selectedFigure = "Selected Figure";

    public GameObject[] figureIMG;

    void Start() {
        int getFigure = PlayerPrefs.GetInt(selectedFigure);

        switch(getFigure){
            case 1:
                figureIMG[0].SetActive(true);
                break;
            case 2:
                figureIMG[1].SetActive(true);
                break;
            case 3:
                figureIMG[2].SetActive(true);
                break;
            case 4:
                figureIMG[3].SetActive(true);
                break;
            case 5:
                figureIMG[4].SetActive(true);
                break;
            case 6:
                figureIMG[5].SetActive(true);
                break;
            case 7:
                figureIMG[6].SetActive(true);
                break;
            case 8:
                figureIMG[7].SetActive(true);
                break;
            case 9:
                figureIMG[8].SetActive(true);
                break;
            case 10:
                figureIMG[9].SetActive(true);
                break;
            case 11:
                figureIMG[10].SetActive(true);
                break;
            case 12:
                figureIMG[11].SetActive(true);
                break;
        }
    }
}
