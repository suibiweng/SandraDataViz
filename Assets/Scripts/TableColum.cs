using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TableColum : MonoBehaviour
{
    public Node mainNode;
    public Image[] gridCubes;
    public Color connected, noconnected, ignore,titleHilight,OutlineColor;
    public Text titleR, titleC;


    // Start is called before the first frame update
    void Start()
    {
        gridCubes = GetComponentsInChildren<Image>();


 


    }




    public void TurnONoutline(string name)
    {

            gridCubes[transNodenametoIndex(name)].GetComponent<Outline>().enabled = true;
    //    gridCubes[transNodenametoIndex(name)].GetComponent<Outline>().effectColor = OutlineColor;

    }


    public void TurnOffoutline(string name)
    {
      //  gridCubes[transNodenametoIndex(name)].GetComponent<Outline>().effectColor = OutlineColor;

        foreach (var box in gridCubes) {

            box.GetComponent<Outline>().enabled =false;

        }
        // gridCubes[transNodenametoIndex(name)].GetComponent<Outline>().enabled = false;

    }

    // Update is called once per frame
    void Update()

    {
        foreach (var box in gridCubes) {
            box.GetComponent<Outline>().effectColor = OutlineColor;
        }



        if (mainNode.isToching) {
            foreach (var box in gridCubes) {

                box.GetComponent<Outline>().enabled = mainNode.isToching;
          //      gridCubes[transNodenametoIndex(name)].GetComponent<Outline>().effectColor = OutlineColor;

            }

        } 



        if (mainNode.isToching) {

            titleR.color = titleHilight;
            titleC.color = titleHilight;


            titleR.fontStyle = FontStyle.Bold;
            titleC.fontStyle = FontStyle.Bold;
     

        } else {

            titleR.color = Color.white;
            titleC.color = Color.white;

            titleR.fontStyle = FontStyle.Normal;
            titleC.fontStyle = FontStyle.Normal;

     

        }




        for (int i = 0; i < mainNode.ConnectedNodes.Count; i++) {



        



            gridCubes[transNodenametoIndex(mainNode.gameObject.name)].color = ignore;
            gridCubes[transNodenametoIndex(mainNode.ConnectedNodes[i].gameObject.name)].color = connected;





        }






    }

    


    int transNodenametoIndex(string Nname) {
        int index = 0;

        switch (Nname) {
              case "A":
                index = 0;
              break;
            case "B":
                index = 1;
                break;
            case "C":
                index = 2;
                break;

            case "D":
                index = 3;
                break;


            case "E":
                index = 4;
                break;

            case "F":
                index = 5;
                break;
        }


        return index;
    }
}
