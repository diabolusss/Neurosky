using UnityEngine;
using System.Collections;

public class ChangeArtController : MonoBehaviour {

    TGCConnectionController controller;
    private Animator animator;

    void Start() {
        animator = GetComponent<Animator>();
        animator.SetInteger("relaxation", 50);
        controller = GameObject.Find("NeuroSkyTGCController").GetComponent<TGCConnectionController>();
        controller.UpdateMeditationEvent += OnUpdateMeditation;

    }

    private void OnUpdateMeditation(int value) {
        animator.SetInteger("relaxation", value);
    }
}
