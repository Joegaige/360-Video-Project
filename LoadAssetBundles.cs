using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadAssetBundles : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        AssetBundle.LoadFromFile("/sdcard/Android/obb/com.dagt/main.1.com.dagt.obb");
    }
}
