using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Fade : MonoBehaviour {

	public float fadeInTime;
	public float fadeOutTime;

	private Color currentColor = Color.black;
	private Image fadeInPanel;

	// Use this for initialization
	void Start() {
		fadeInPanel = GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update() {
		if (Time.timeSinceLevelLoad < fadeInTime) {
			// Fade in, calculate the portion of it
			float fadeInChange = Time.deltaTime / fadeInTime;
			currentColor.a -= fadeInChange;
			fadeInPanel.color = currentColor;
		} else {
			gameObject.SetActive(false);
		}
	}
}
