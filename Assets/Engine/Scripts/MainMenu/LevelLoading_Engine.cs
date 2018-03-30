using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Engine.Scripts.MainMenu
{
    public class LevelLoading_Engine : MonoBehaviour
    {
      

        public void RunAction(string actionName)
        {
            if (actionName == "QuitGame")
                QuitGame();
            else
                SceneManager.LoadScene(actionName);
            
        }

        

        private void QuitGame ()
        {
            print("Quiting Game");
            Application.Quit();
        }
    }
}