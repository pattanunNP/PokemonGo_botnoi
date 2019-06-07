using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArScripts : MonoBehaviour
{
    // Start is called before the first frame update
    private string deviceName;
    private WebCamTexture wct;
    private WebCamDevice[]devices;
    public int deviceNumber;
    private Renderer arRenderer;
    void Start()
    {
        arRenderer = GetComponent<Renderer>();
        PlayAR();
    }

    // Update is called once per frame
    void Update()
    {}
    void OnDisable() {
        StopAR();
    }
    public void StopAR() {
        wct.Stop();
    }
    public void PlayAR() {
        devices = WebCamTexture.devices;
        deviceName = devices[deviceNumber].name;
        wct = new WebCamTexture(deviceName, 600, 600, 30);
        arRenderer.material.mainTexture = wct;
        wct.Play();
    }
}
