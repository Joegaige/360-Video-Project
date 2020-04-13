using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    // Start is called before the first frame update
    string sceneName;

    bool pressed;

    VideoPlayer currentVid; 

    void Start()
    {
        currentVid = FindObjectOfType<VideoPlayer>();
        sceneName = SceneManager.GetActiveScene().name;
    }

    // Update is called once per frame
    void Update()
    {
        ulong currentFrame = (ulong)currentVid.frame;
       if(currentFrame == currentVid.frameCount)
        {
            checkScene();
        }

       if(OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger) || OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
        {
            checkScene();
        }
       else if(OVRInput.GetDown(OVRInput.Button.SecondaryHandTrigger) || OVRInput.GetDown(OVRInput.Button.PrimaryHandTrigger))
        {
            checkSceneReversed();
        }
        //OVRInput.Get(OVRInput.Axis1D.PrimaryHandTrigger) > 0 && pressed = false ) || OVRInput.Get(OVRInput.Axis1D.SecondaryHandTrigger) > 0
        //OVRInput.GetDown(OVRInput.Button.SecondaryHandTrigger) || OVRInput.GetDown(OVRInput.Button.PrimaryHandTrigger) ||
        //In the quest it thinks this is the same as button.one

        if (OVRInput.GetDown(OVRInput.Button.SecondaryThumbstick) || OVRInput.GetDown(OVRInput.Button.PrimaryThumbstick))
        {
            SceneManager.LoadScene("MainMenu_Gaze");
        }
    }

    void checkScene()
    {
        switch (sceneName)
        {
            case "2D_BogusBasin":
                SceneManager.LoadScene("2D_McCall");
                break;

            case "2D_McCall":
                SceneManager.LoadScene("2D_KoiPond");
                break;

            case "2D_KoiPond":
                SceneManager.LoadScene("2D_Ducks");
                break;

            case "2D_Ducks":
                SceneManager.LoadScene("2D_BogusBasin");
                break;

        }
    }

    void checkSceneReversed() {
        switch (sceneName)
        {
            case "2D_BogusBasin":
                SceneManager.LoadScene("2D_Ducks");
                break;

            case "2D_McCall":
                SceneManager.LoadScene("2D_BogusBasin");
                break;

            case "2D_KoiPond":
                SceneManager.LoadScene("2D_McCall");
                break;

            case "2D_Ducks":
                SceneManager.LoadScene("2D_KoiPond");
                break;

        }
    }
}
