using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private GameHUD hud;
    private MouseLook mouseLook;
    private bool gamePaused = false;


    private void Awake()
    {
        mouseLook = FindObjectOfType<MouseLook>();
    }

    // Start is called before the first frame update
    void Start()
    {
        gamePaused = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Cancel") == true)
        {
            TogglePauseGame();
        }     
    }


    public void TogglePauseGame()
    {
        gamePaused = hud.TogglePauseMenu();
   
        if(gamePaused == true)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }
}
