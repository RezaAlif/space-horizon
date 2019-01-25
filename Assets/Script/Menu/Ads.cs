using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;


public class Ads : MonoBehaviour {
    private string gameId = "1272196";
    public string placementId = "video";
    Button m_Button;

    // Use this for initialization
    void Start () {
        m_Button = GetComponent<Button>();
        if (m_Button) m_Button.onClick.AddListener(ShowAd);

        if (Advertisement.isSupported)
        {
            Advertisement.Initialize(gameId, true);
        }
    }

    // Update is called once per frame
    void Update () {
        if (m_Button) m_Button.interactable = Advertisement.IsReady(placementId);
    }

    void ShowAd()
    {
        ShowOptions options = new ShowOptions();
        options.resultCallback = HandleShowResult;

        Advertisement.Show(placementId, options);
    }

    void HandleShowResult(ShowResult result)
    {
        if (result == ShowResult.Finished)
        {
            Debug.Log("Video completed - Offer a reward to the player");

        }
        else if (result == ShowResult.Skipped)
        {
            Debug.LogWarning("Video was skipped - Do NOT reward the player");

        }
        else if (result == ShowResult.Failed)
        {
            Debug.LogError("Video failed to show");
        }
    }
}
