using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class Test : MonoBehaviour {

    public void NormalAd()
    {
        if(Advertisement.IsReady("video"))
        {
            Advertisement.Show("video");
        }
    }

    public void RewardedAd()
    {
        if (Advertisement.IsReady("rewardedVideo"))
        {
            Advertisement.Show("rewardedVideo");
        }
    }
}
