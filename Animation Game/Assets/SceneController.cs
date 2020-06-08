using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Wat je moet gebruiken als je wilt switchen tussen scenes.

public class SceneController : MonoBehaviour{

    public void PlayGame()
    {
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

    public void DrawScreen()
    {
        SceneManager.LoadScene("Drawer");
    }

    public void DrawToLife()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
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
