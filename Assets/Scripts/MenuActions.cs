using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuActions : MonoBehaviour {
	public void OnStart() {
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}

	public void OnSettings() {
		Debug.Log("Clicked 'Settings'");
	}

	public void OnQuit() {
#if UNITY_EDITOR
		// This closes the game in the editor window
		UnityEditor.EditorApplication.isPlaying = false;
#else
		// This closes the game when running standalone
		Application.Quit(0);
#endif
	}
}
