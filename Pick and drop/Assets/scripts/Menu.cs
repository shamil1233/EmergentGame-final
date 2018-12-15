using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ChangeScene : MonoBehaviour {

// once the play button is pressed it will load gameScene by the index number of it.
   public void GameScene(int gameScene) 
   {
	   SceneManager.LoadScene (gameScene);
   }

//this function will end the game screen. which is handled by Quit() function in Unity.
   public void Quit()
   {
		UnityEditor.EditorApplication.isPlaying = false;
   }
  
}
