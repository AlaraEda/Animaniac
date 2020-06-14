using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    //De Variabele is gevuld in Unity, elke keer dat we "controller" typen roepen we de Character Controller 2D(Script) aan.
    public CharacterController2D controller;
    public Animator animator;

    public float runSpeed = 80f;        //Default value = 40

    float horizontalMove = 0f;          //Default value = 0
    bool jump = false;
    bool crouch = false;

     

    // Update is called once per frame
    //Get input from our Player
    void Update(){

        //Check if we get Input van de Player, horizontal axis houd in dat je een value kan hebben tussen -1 en 1.
        //Left-key or A-key = -1
        //Right-key or D-key = 1
        //Same goes for playstation controllers.
        
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;             //Horizontal move is or -40 or 40

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));                  //Speciaal voor Loop animatie
        
        if (Input.GetButtonDown("Jump")){
            jump = true;                                                        //Jump is een button die in je "project settings" staat
            animator.SetBool("IsJumping", true);                                //Jump animatie
        }

        if (Input.GetButtonDown("Crouch")){
            crouch = true;
        }else if (Input.GetButtonUp("Crouch")){
            crouch = false;
        }
    }

    //Function that tells player when to stop the jumping animation
    public void OnLanding()
    {
        animator.SetBool("IsJumping", false);
    }

    //Function that tells player to start crouching.
    public void OnCrouching (bool isCrouching)
    {
        animator.SetBool("IsCrouching", isCrouching);
    }

    //Function that is dedicated for physics. 
    //This function get's called upon if fixed amount of times per second have passed.
    //Apply the input van de Update()-function to our Character
    private void FixedUpdate()
    {
        //Move Character
        //We want to move according to our horizontal-variable
        // Time.fixedDeltaTime berekent wanneer de laatste keer was dat de FixedUpdate()-functie was opgeroepen.Het zorgt ervoor dat hoevaak je ook op de knop drukt, je nog steeds dezelfde snelheid behoud. 
        //             (Welke richting?, should I crouch?,           should I jump?)
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }

    /*
     Interesting to know:
     Debug.Log( ) is een concole log. 
     */
}
