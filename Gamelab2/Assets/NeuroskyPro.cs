using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NeuroskyPro : MonoBehaviour {

    TGCConnectionController controller;

    private Text text;
    private int meditation = 50;
    private int attention = 50;

    void Start() {
        text = GetComponent<Text>();
        UpdateUI();
        controller = GameObject.Find("NeuroSkyTGCController").GetComponent<TGCConnectionController>();

        controller.UpdateMeditationEvent += OnUpdateMeditation;
        controller.UpdateAttentionEvent += OnUpdateAttention;
    }

    private void OnUpdateAttention(int value) {
        attention = value;
        UpdateUI();
    }

    private void OnUpdateMeditation(int value) {
        meditation = value;
        UpdateUI();
    }
    void UpdateUI() {
        text.text = "Meditation: " + meditation + "% \n Attention: " + attention + "%";
    }
}
