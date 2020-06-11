using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;          //Wat je moet gebruiken als je wilt switchen tussen scenes.

/*
 * Check 3 things:
 * 1. Check "In Range"
 * 2. Press Key to Start
 * 3. Execute interaction/Do something!
 */

public class Interactable : MonoBehaviour
{
    public bool isInRange;                  //Default = false
    public KeyCode interactKey;             //Default = None, het is de key die je indrukt om te interacten met het object.
    public UnityEvent interactAction;       //Zorgt ervoor dat je listeners kan toevoegen in Unity.

    // Update is called once per frame
    void Update()
    {
        //If we're in range to interact with sign.
        if (isInRange)          
        {

            //And player presses the E-key
            if (Input.GetKeyDown(interactKey))
            {
                Debug.Log("Ga naar Draw-Screen");
                //Fire Unity Event, ga naar andere scherm(?)
                //interactAction.Invoke();    //Fire alle events die je hebt opgeslagen in Unity.

                SceneManager.LoadScene("Drawer");
            }
        }
    }

    //If Player is in range, get's called when you STOP intercecting.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isInRange = true;
            Debug.Log("Player now in range");
        }
    }

 
    //Get's called when you STOP intercecting.
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isInRange = false;
            Debug.Log("Player now OUT range");
        }
    }

}
