using UnityEngine;
using System.Collections;

public class HUDScript : MonoBehaviour {

	float playerScore = 0;
	
	// Update is called once per frame
	void Update () 
	{
		playerScore += Time.deltaTime;
	}

	public void IncreaseScore(int amount)
	{
		playerScore += amount;
	}

	public void OnDisable()
	{
		PlayerPrefs.SetInt("Score", (int)playerScore* 100);
	}

	void OnGUI()
	{
		GUI.Label(new Rect(100, 100, 100, 300), "Score: " + (int)(playerScore * 100));
	}
}
