using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public Transform player;
	public Text scoreText;
	public float scoreT;
	
	// Update is called once per frame
	void Update () {
        scoreT = -player.position.z;
		scoreText.text = scoreT.ToString("0");
	}
}
