using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MusicManager : MonoBehaviour {

	public AudioClip[] audioClips;
	private AudioSource music;

	void Awake() {
		// Don't destroy this gameObject when a new scene is loaded.
		DontDestroyOnLoad(gameObject);
	}

	// Use this for initialization
	void Start() {
		music = gameObject.GetComponent<AudioSource>();
	}

	void OnLevelWasLoaded(int level) {
		// Since the first scene will never invoke this function, level 0 will never be passed into here
		if (level < 0 || level >= audioClips.Length) {
			Debug.LogError("Level index out of range");
			return;
		}
		AudioClip thisLevelMusic = audioClips[level];
		if (thisLevelMusic) {
			music.clip = thisLevelMusic;
			music.loop = true;
			music.PlayDelayed(1);
		}
	}

	public void SetVolume(float volume) {
		music.volume = volume;
	}
}
