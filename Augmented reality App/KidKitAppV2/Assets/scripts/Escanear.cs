using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Escanear : MonoBehaviour,IPointerDownHandler,IPointerUpHandler {
    public string escena;
    public void OnPointerDown(PointerEventData eventData)
    {
        SceneManager.LoadScene(escena);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        throw new NotImplementedException();
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
