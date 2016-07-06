using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SettingsController : MonoBehaviour {

	public Slider volumeSlider;
	public Slider difficultySlider;

	private MusicManager musicManager;
	private LevelManager levelManager;

	// Use this for initialization
	void Start() {
		musicManager = GameObject.FindObjectOfType<MusicManager>();
		levelManager = GameObject.FindObjectOfType<LevelManager>();
		volumeSlider.value = PlayerPrefsManager.getMasterVolume();
		difficultySlider.value = PlayerPrefsManager.getDifficulty();
	}
	
	// Update is called once per frame
	void Update() {
		musicManager.SetVolume(volumeSlider.value);

	}

	public void SaveAndExit() {
		PlayerPrefsManager.setMasterVolume(volumeSlider.value);
		PlayerPrefsManager.setDifficulty((int)difficultySlider.value);
		levelManager.LoadLevel("01 Start Menu");
	}
}
