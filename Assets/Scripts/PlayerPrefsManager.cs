using UnityEngine;
using System.Collections;

public class PlayerPrefsManager : MonoBehaviour {

	const string MASTER_VOLUME_KEY = "master_volume";
	const string DIFFICULTY_KEY = "difficulty";
	const string UNLOCK_LEVEL_KEY = "unlock_level_";

	public static void setMasterVolume(float volume) {
		if (volume >= 0f && volume <= 1f) {
			PlayerPrefs.SetFloat(MASTER_VOLUME_KEY, volume);
		} else {
			Debug.LogError("volume out of range");
		}
	}

	public static float getMasterVolume() {
		return PlayerPrefs.GetFloat(MASTER_VOLUME_KEY);
	}

	public static void setDifficulty(int difficulty) {
		if (difficulty >= 0 && difficulty <= 2) {
			PlayerPrefs.SetInt(DIFFICULTY_KEY, difficulty);
		} else {
			Debug.LogError("difficulty out of range");
		}
	}

	public static int getDifficulty() {
		return PlayerPrefs.GetInt(DIFFICULTY_KEY);
	}
}
