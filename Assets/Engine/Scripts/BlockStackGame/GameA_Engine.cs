using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Engine.Scripts.BloclStackGame
{
    public class GameA_Engine : MonoBehaviour
    {

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            int fingerCount = 0;
            foreach (Touch touch in Input.touches)
            {
                if (touch.phase != TouchPhase.Ended && touch.phase != TouchPhase.Canceled)
                    fingerCount++;
            }
            if (fingerCount > 0)
                print(fingerCount);
        }
    }
}