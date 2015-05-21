using UnityEngine;
using System.Collections;

public class neuroskytest : MonoBehaviour {

    TGCConnectionController controller;

    private int _poorSignal;
    private int _attention;
    private int _meditation;
    private float _delta;
	// Use this for initialization
	void Start () {

        controller = GameObject.Find("NeuroSkyTGCController").GetComponent<TGCConnectionController>();

        controller.UpdatePoorSignalEvent += OnUpdatePoorSignal;
        controller.UpdateAttentionEvent += OnUpdateAttention;
        controller.UpdateMeditationEvent += OnUpdateMeditation;

        controller.UpdateDeltaEvent += OnUpdateDelta;
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown("space")) 
        {
            controller.Connect();
        }
	}

    void OnUpdatePoorSignal(int value)
    {
        _poorSignal = value;
    }

    void OnUpdateAttention(int value)
    {
        _attention = value;
    }
    void OnUpdateMeditation(int value)
    {
        _meditation = value;
    }
    void OnUpdateDelta(float value)
    {
        _delta = value;
    }
}
