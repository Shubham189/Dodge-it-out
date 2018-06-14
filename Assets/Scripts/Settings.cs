﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Settings : MonoBehaviour {

    public AudioMixer audioMixer;

	public Dropdown resolutionDropdown;
	Resolution[] resolutions;

	void Start(){
		resolutions = Screen.resolutions;
		List<string> options=new List<string>(); 

		int currentResolutionindex = 0;
		resolutionDropdown.ClearOptions ();

		for (int i = 0; i < resolutions.Length; i++) {
			string option = resolutions [i].width + "x" + resolutions [i].height;
			options.Add (option);

			if (resolutions [i].height == Screen.currentResolution.height &&
			   resolutions [i].width == Screen.currentResolution.width) {
			   
				currentResolutionindex = i;
			}
		}

		resolutionDropdown.AddOptions (options);
		resolutionDropdown.value = currentResolutionindex;
		resolutionDropdown.RefreshShownValue ();
	}

	public void SetResolution(int resolutionIndex)
	{
		Resolution resolution=resolutions[resolutionIndex];
		Screen.SetResolution(resolution.width,resolution.height,Screen.fullScreen);
	}
	public void SetVolume(float volume)
	{
         audioMixer.SetFloat("volume",volume);
		 
	}

	public void SetQuality(int qualityIndex){
		QualitySettings.SetQualityLevel (qualityIndex);
	}
	public void SetFullScreen(bool isFullScreen){
		Screen.fullScreen = isFullScreen;
	}

}


