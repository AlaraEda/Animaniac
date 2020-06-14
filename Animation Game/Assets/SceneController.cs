using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;    //Wat je moet gebruiken als je wilt switchen tussen scenes.
using UnityEngine.UI;                 //Wat je nodig hebt voor het gebruiken van een InputField.


public class SceneController : MonoBehaviour{

    public InputField playername;

    public void PlayGame()
    {
        //Pas information - Player name to gameScreen;
        Debug.Log("Player Name is:"+ playername.text);

        //Ga direct naar de Main/Game
        SceneManager.LoadScene("Main");

        /*
         * Een andere optie is SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
         * Je begint vanaf Menu, die zit op plaats 0
         * Load next level in the que. Je load dus de Play-Screen/MainScreen.
         * 
         * Dan ga je ook naar die scene namelijk. Met +1, zeg je eigenlijk dat je naar de volgende
         * scene wilt gaan door het in je file --> build settings te slepen.
        */
    }

    //Verander naam Menu() naar terug.
    public void Menu()
    {
        //Ga vanaf de PlayScreen/Mainscreen terug naar de Menu.
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }


    public void QuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit(); //Ingebouwde quit functie van unity
    }
}
