using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public Color touchColor,ConnectedColor,ConnectlineColor;

    public Node[] nodes;
    public GameObject b;

    public TableColum[] colums;

    public Color C_ConnectedColor, OutlineColor,TitleColor,ignoreColor;




    // Start is called before the first frame update
    void Start()
    {
        foreach (var n in nodes) {
            n.connectionColor = ConnectedColor;
            n.touchColor = touchColor;
            n.ConnectlineColor = ConnectlineColor;

        }

        foreach (var c in colums) {
            c.connected = C_ConnectedColor;
            c.OutlineColor = OutlineColor;
            c.titleHilight = TitleColor;
            c.ignore = ignoreColor;

        }



    }

    // Update is called once per frame
    void Update()
    {

        foreach (var n in nodes) {
            n.connectionColor = ConnectedColor;
            n.touchColor = touchColor;
            n.ConnectlineColor = ConnectlineColor;

        }

        foreach (var c in colums) {
            c.connected = C_ConnectedColor;
            c.OutlineColor = OutlineColor;
            c.titleHilight = TitleColor;
            c.ignore = ignoreColor;

        }

        debugTest(Input.GetKeyDown(KeyCode.A), Input.GetKeyUp(KeyCode.A), nodes[0]);
        debugTest(Input.GetKeyDown(KeyCode.B), Input.GetKeyUp(KeyCode.B), nodes[1]);
        debugTest(Input.GetKeyDown(KeyCode.C), Input.GetKeyUp(KeyCode.C), nodes[2]);
        debugTest(Input.GetKeyDown(KeyCode.D), Input.GetKeyUp(KeyCode.D), nodes[3]);
        debugTest(Input.GetKeyDown(KeyCode.E), Input.GetKeyUp(KeyCode.E), nodes[4]);
        debugTest(Input.GetKeyDown(KeyCode.F), Input.GetKeyUp(KeyCode.F), nodes[5]);



    }

    void debugTest(bool keydown, bool keyup, Node node) {

        if (keydown) {
            node.isTouch();
            b.BroadcastMessage("TurnONoutline", node.gameObject.name);

        }

        if (keyup) {

            node.notTouch();
            b.BroadcastMessage("TurnOffoutline", node.gameObject.name);
        }






    }
}
