using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;                   //Bc we are dealing with UI elements.

public class NameTransfer : MonoBehaviour
{
    public string theName;
    public GameObject inputField;       //Waar je je naam intypt
    public GameObject textDisplay;      //Het laten zien van de tekst

    public void StoreName()
    {
        theName = inputField.GetComponent<Text>().text;
        textDisplay.GetComponent<Text>().text = "Welcome " + theName + " to the game";
    }
}
