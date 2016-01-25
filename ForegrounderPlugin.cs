using UnityEngine;
using System.Collections;

#if UNITY_EDITOR_OSX || UNITY_STANDALONE_OSX
using System.Runtime.InteropServices;
#endif

public class ForegrounderPlugin : MonoBehaviour {
    bool first=true;

    #if UNITY_STANDALONE_OSX

    [DllImport ("Foregroundr")]
    private static extern void activateWindow();

	// Update is called once per frame
    void Update () {
        if (first)
        {
            first = false;
            print("activating");
            activateWindow();
        }
	}

    #endif
}
