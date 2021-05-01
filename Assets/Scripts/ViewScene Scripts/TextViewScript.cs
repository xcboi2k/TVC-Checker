using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Linq;

public class TextViewScript : MonoBehaviour
{
    private const string selectedFigure = "Selected Figure";

    public static List<string> textArray;
    public Text informationText;
    private int[] rowsToRead = new int[7];
    public TextAsset textFile;

    void Start()
    {
        int getFigure = PlayerPrefs.GetInt(selectedFigure);

        if(getFigure == 1){
            int num_set = 0;
            for(int i = 0; i < rowsToRead.Length; i++){
                rowsToRead[i] = num_set;
                num_set++;
            }
            readTextFile();
        }

        else if(getFigure == 2){
            int num_set = 7;
            for(int i = 0; i < rowsToRead.Length; i++){
                rowsToRead[i] = num_set;
                num_set++;
            }
            readTextFile();
        }

        else if(getFigure == 3){
            int num_set = 14;
            for(int i = 0; i < rowsToRead.Length; i++){
                rowsToRead[i] = num_set;
                num_set++;
            }
            readTextFile();
        }

        else if(getFigure == 4){
            int num_set = 21;
            for(int i = 0; i < rowsToRead.Length; i++){
                rowsToRead[i] = num_set;
                num_set++;
            }
            readTextFile();
        }

        else if(getFigure == 5){
            int num_set = 28;
            for(int i = 0; i < rowsToRead.Length; i++){
                rowsToRead[i] = num_set;
                num_set++;
            }
            readTextFile();
        }

        else if(getFigure == 6){
            int num_set = 35;
            for(int i = 0; i < rowsToRead.Length; i++){
                rowsToRead[i] = num_set;
                num_set++;
            }
            readTextFile();
        }

        else if(getFigure == 7){
            int num_set = 42;
            for(int i = 0; i < rowsToRead.Length; i++){
                rowsToRead[i] = num_set;
                num_set++;
            }
            readTextFile();
        }

        else if(getFigure == 8){
            int num_set = 49;
            for(int i = 0; i < rowsToRead.Length; i++){
                rowsToRead[i] = num_set;
                num_set++;
            }
            readTextFile();
        }

        else if(getFigure == 9){
            int num_set = 56;
            for(int i = 0; i < rowsToRead.Length; i++){
                rowsToRead[i] = num_set;
                num_set++;
            }
            readTextFile();
        }

        else if(getFigure == 10){
            int num_set = 63;
            for(int i = 0; i < rowsToRead.Length; i++){
                rowsToRead[i] = num_set;
                num_set++;
            }
            readTextFile();
        }

        else if(getFigure == 11){
            int num_set = 70;
            for(int i = 0; i < rowsToRead.Length; i++){
                rowsToRead[i] = num_set;
                num_set++;
            }
            readTextFile();
        }

        else if(getFigure == 12){
            int num_set = 77;
            for(int i = 0; i < rowsToRead.Length; i++){
                rowsToRead[i] = num_set;
                num_set++;
            }
            readTextFile();
        }
    }

    void readTextFile(){
        textArray = textFile.text.Split('\n').ToList();

        for(int i = 0; i < rowsToRead.Length; i++){
            if(rowsToRead[0] < 0 || rowsToRead.Length == 0){
                informationText.text = textFile.text;
            }
            else{
                informationText.text += textArray[rowsToRead[i]] + "\n"; 
            }
        }
    }
}
