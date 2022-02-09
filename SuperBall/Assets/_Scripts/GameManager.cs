using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public enum Levels { Menu = 0, Game = 1, End = 2}


    public void ChangeLevel(Levels level)
    {
        //Permite cambiar de escena
        SceneManager.LoadScene((int)level);
    }

    public void ChangeLevel(int index)
    {
        SceneManager.LoadScene(index);
    }    

    public void Quit()
    {
        //Sale del juego
        Application.Quit();
    }
}
