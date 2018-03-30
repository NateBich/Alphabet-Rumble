using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Engine.Scripts.Buttons
{
    public class Button_Engine : MonoBehaviour
    {
        private Button thisButton; // This button, sets it self automatically
        public GameObject actionObj; // Engine that loads the level
        public string levelName; // Name of level needing to be opened

        void Start()
        {
            if (!thisButton)
            {
                thisButton = gameObject.GetComponent<Button>();
                thisButton.onClick.AddListener(LevelLoader);
            }
            if (!actionObj)
                print("Assign Engine to drive button");

        }
           
        // Loads the level associated with the button.
        void LevelLoader ()
        {       
            actionObj.GetComponent<Component>().SendMessage("RunAction", levelName,  SendMessageOptions.DontRequireReceiver);
            print("Clicked");
        }
    }
}