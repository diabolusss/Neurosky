using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ChangeArtSprite : MonoBehaviour {

    TGCConnectionController controller;
    private SpriteRenderer spriteRenderer;
    public List<Sprite> sprites = new List<Sprite>();

    void Start() {
        spriteRenderer = GetComponent<SpriteRenderer>();
        controller = GameObject.Find("NeuroSkyTGCController").GetComponent<TGCConnectionController>();
        controller.UpdateMeditationEvent += OnUpdateMeditation;
    }

    private void OnUpdateMeditation(int value) {
        if (value < 34) {
            spriteRenderer.sprite = sprites[0];
        }
        else if (value < 67) {
            spriteRenderer.sprite = sprites[1];
        }
        else {
            spriteRenderer.sprite = sprites[2];
        }
    }
}
