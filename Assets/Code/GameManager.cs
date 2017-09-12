using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR;

public class GameManager : Singleton<GameManager> {

	protected GameManager () { }

    public void SetVR()
    {
        VRSettings.LoadDeviceByName("cardboard");
        VRSettings.enabled = true;
    }

    public void Set360()
    {
        VRSettings.LoadDeviceByName("cardboard");
        VRSettings.enabled = false;
    }

}
