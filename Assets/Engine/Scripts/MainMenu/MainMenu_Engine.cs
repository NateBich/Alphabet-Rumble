using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Engine.Scripts.MainMenu
{
    public class MainMenu_Engine : MonoBehaviour
    {

        public GameObject windowObject;

        // Use this for initialization
        void Start()
        {
            if (windowObject)
            {
                windowObject.SetActive(false);
            }
            else
                print("No Window in Scene");

        }

        public void RunAction(string actionName)
        {
            if (actionName == "WindowOpen")
                OpenWindow();

        }

        private void OpenWindow()
        {
            windowObject.SetActive(true);
            print("Window Appeared");
        }
    }
}