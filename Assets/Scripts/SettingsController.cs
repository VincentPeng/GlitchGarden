using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SettingsController : MonoBehaviour {

	public Slider volumeSlider;
	public Slider difficultySlider;

	const float DEFAULT_VOLUME = 0.5f;
	const int DEFAULT_DIFFICULTY = 1;

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

	public void SetDefaults() {
		PlayerPrefsManager.setMasterVolume(DEFAULT_VOLUME);
		PlayerPrefsManager.setDifficulty(DEFAULT_DIFFICULTY);
		volumeSlider.value = DEFAULT_VOLUME;
		difficultySlider.value = DEFAULT_DIFFICULTY;
	}
}
