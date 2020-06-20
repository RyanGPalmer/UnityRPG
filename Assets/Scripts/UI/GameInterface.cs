using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace RPG.UI
{
    public class GameInterface : MonoBehaviour
    {
        [SerializeField]
        private GameObject menu;

        [SerializeField]
        private List<GameObject> thingsToDisable;

        public void Start()
        {
            menu.SetActive(false);
        }

        public void Update()
        {
            // if (Input.anyKeyDown) {
            // 	if (Input.GetKeyDown(KeyCode.Escape))
            // 		ToggleMenu();
            // }
        }

        public void ToggleMenu()
        {
            menu.SetActive(!menu.activeSelf);

            foreach (GameObject thing in thingsToDisable)
                thing.SetActive(!menu.activeSelf);
        }

        public void ExitToMainMenu()
        {
            SceneManager.LoadScene(0);
        }
    }
}