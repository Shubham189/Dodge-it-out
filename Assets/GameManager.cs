using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
	public float restartDelay=1f;
	public GameObject CompleteLevelUI;
	bool gameIsOver=false;
	public void GameOver(){
		if (gameIsOver == false) {
			Debug.Log ("Game Over");
			gameIsOver = true;
			Invoke("Restart",restartDelay);
		}
	   
	}
	public void Win(){
		Debug.Log ("Win!!!!");
		CompleteLevelUI.SetActive (true);
	}

	void Restart(){
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);

	}

}
