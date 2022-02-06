using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;
public class AnalyticsController : MonoBehaviour
{
    private void Start()
    {
        //No need just for showing
        Debug.Log(Analytics.EnableCustomEvent("ButtonPressed",true));
    }
    public void onRedButtonPressed()
    {
        AnalyticsResult result= Analytics.CustomEvent("ButtonPressed",new Dictionary<string, object> 
        {
            {"ButtonColor", "red"},
            {"Time",Time.realtimeSinceStartup}

        });

        Debug.Log("Result for red button press: " + result);
    }

    public void onGreenButtonPressed()
    {
        AnalyticsResult result = Analytics.CustomEvent("ButtonPressed", new Dictionary<string, object>
        {
            {"ButtonColor", "green"},
            {"Time", Time.realtimeSinceStartup}

        });

        Debug.Log("Result for green button press: " + result);
    }
}
