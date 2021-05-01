using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuControllerScript : MonoBehaviour
{
    public GameObject page1, page2, page3, page4, page5;
    int page;

    public void NextPage(){
        if(page == 0){
            page1.SetActive(false);
            page2.SetActive(true);
            page = 1;
        }

        else if(page == 1){
            page2.SetActive(false);
            page3.SetActive(true);
            page = 2;
        }

        else if(page == 2){
            page3.SetActive(false);
            page4.SetActive(true);
            page = 3;
        }

        else if(page == 3){
            page4.SetActive(false);
            page5.SetActive(true);
            page = 4;
        }
    }

    public void PreviousPage(){
        if(page == 1){
            page2.SetActive(false);
            page1.SetActive(true);
            page = 0;
        }

        else if(page == 2){
            page3.SetActive(false);
            page2.SetActive(true);
            page = 1;
        }

        else if(page == 3){
            page4.SetActive(false);
            page3.SetActive(true);
            page = 2;
        }

        else if(page == 4){
            page5.SetActive(false);
            page4.SetActive(true);
            page = 3;
        }
    }
}
