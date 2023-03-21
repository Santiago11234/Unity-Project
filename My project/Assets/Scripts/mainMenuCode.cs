using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class mainMenuCode : MonoBehaviour
{
    [Header("Volume Settings")]
    [SerializeField] private TMP_Text soundText = null;
    [SerializeField] private Slider soundSlider = null;
    [SerializeField] private TMP_Text musicText = null;
    [SerializeField] private Slider musicSlider = null;

    public int quality;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   public void loadScene(int sceneName) {
    SceneManager.LoadScene(sceneName);
   }

   public void ExitButton() {
    Application.Quit();
   }

   public void SetVolumeSound(float volume) {
        AudioListener.volume = volume;
        soundText.text = volume.ToString("0.0");
        soundSlider.value = volume;
   }
  

   public void VolumeApplySound() {
    PlayerPrefs.SetFloat("masterVolume", AudioListener.volume);
   }

 public void SetVolumeMusic(float volume) {
        AudioListener.volume = volume;
        musicText.text = volume.ToString("0.0");
        musicSlider.value = volume;
   }
  

   public void VolumeApplyMusic() {
    PlayerPrefs.SetFloat("masterVolume", AudioListener.volume);
   }

   public void SetQuality(int qualityLevl) {
    quality = qualityLevl;
   }

   public void GraphicsApply() {
    PlayerPrefs.SetInt("UnityGraphicsQuality", quality);
    QualitySettings.SetQualityLevel(quality);
   }
   
}
