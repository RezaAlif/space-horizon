using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class GoogleAdsDown : MonoBehaviour {
    private BannerView bannerView;

    // Use this for initialization
    void Start()
    {
        showBannerAd();
    }

    private void showBannerAd()
    {
        string adID = "ca-app-pub-1457560942718397/3300163643";

        // Create a 320x50 banner at the top of the screen.
        BannerView bannerView = new BannerView(adID, AdSize.Banner, AdPosition.Bottom);
        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        // Load the banner with the request.
        bannerView.LoadAd(request);

    }

    // Update is called once per frame
    void Update () {
		
	}
}
