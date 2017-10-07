using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class VideoPlayerBehaviour : MonoBehaviour {

	public Material playButtonMaterial;
	public Material pauseButtonMaterial;
	public Renderer screenRenderer;
	public Text currentMinutes;
	public Text currentSeconds;
	public Text totalMinutes;
	public Text totalSeconds;
	public PlayHeadMover playHeadMover;

	private VideoPlayer videoPlayer;
	public VideoPlayer Video {
		get { return videoPlayer; }
	}

	void Awake () {

		videoPlayer = GetComponent<VideoPlayer> ();
	}

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (videoPlayer.isPlaying) {

			SetCurrentTimeUI ();
			playHeadMover.MovePlayhead (CalculatePlayedFraction());
		}
	}


	public void PlayPause () {

		if (videoPlayer.isPlaying) {

			videoPlayer.Pause ();
			screenRenderer.material = playButtonMaterial;
		} else {

			videoPlayer.Play ();
			SetTotalTimeUI ();
			screenRenderer.material = pauseButtonMaterial;
		}

	}

	void SetCurrentTimeUI () {

		string minutes = Mathf.Floor((int) videoPlayer.time / 60).ToString("00");
		string seconds = ((int) videoPlayer.time % 60).ToString("00");

		currentMinutes.text = minutes;
		currentSeconds.text = seconds;
	}

	void SetTotalTimeUI () {

		string minutes = Mathf.Floor((int) videoPlayer.clip.length / 60).ToString("00");
		string seconds = ((int) videoPlayer.clip.length % 60).ToString("00");

		totalMinutes.text = minutes;
		totalSeconds.text = seconds;
	}

	double CalculatePlayedFraction () {

		double fraction = (double)videoPlayer.frame / (double)videoPlayer.clip.frameCount;

		return fraction;

	}
}
