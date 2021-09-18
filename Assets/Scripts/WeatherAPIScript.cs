using UnityEngine;
using UnityEngine.Networking;
using System.Collections;
using TMPro;

public class WeatherAPIScript : MonoBehaviour
{
    [SerializeField] GameObject weatherTextObject;
    [SerializeField] Vector2    coordinates = new Vector2(-87.62f, 41.88f); // Chicago
    [SerializeField] string     units = "imperial";
    [SerializeField] string     apiKey = "01f2a65be3f1b854c334c3a266a0ad20";

    [SerializeField] private bool showReceived = false;

    string url = "http://api.openweathermap.org/data/2.5/weather?";

    void Start()
    {
        if(apiKey.Length == 0)
        {
            Debug.Log($"Please enter an API Key for {name}.");
            return;
        }

        url += $"lat={coordinates.y}&lon={coordinates.x}";
        url += $"&APPID={apiKey}";
        url += $"&units={units}";

        // wait a couple seconds to start and then refresh every 10 minutes
        InvokeRepeating("GetDataFromWeb", 2f, 600);
    }

    void GetDataFromWeb()
        => StartCoroutine(GetRequest(url));


    IEnumerator GetRequest(string uri)
    {
        using (UnityWebRequest webRequest = UnityWebRequest.Get(uri))
        {
            // Request and wait for the desired page.
            yield return webRequest.SendWebRequest();


            if(webRequest.isNetworkError)
            {
                Debug.Log(": Error: " + webRequest.error);
            }
            else
            {
                // print out the weather data to make sure it makes sense
                if(showReceived)
                     Debug.Log(":\nReceived: " + webRequest.downloadHandler.text);

                // grab the current temperature and simplify it if needed
                int startTemp = webRequest.downloadHandler.text.IndexOf("temp", 0);
                int endTemp   = webRequest.downloadHandler.text.IndexOf(",",    startTemp);
                double tempF =
                    float.Parse(webRequest.downloadHandler.text.Substring(startTemp + 6, (endTemp - startTemp - 6)));
                int easyTempF = Mathf.RoundToInt((float)tempF);
                //Debug.Log ("integer temperature is " + easyTempF.ToString());
                int startConditions = webRequest.downloadHandler.text.IndexOf("main", 0);
                int endConditions   = webRequest.downloadHandler.text.IndexOf(",",    startConditions);
                string conditions =
                    webRequest.downloadHandler.text.Substring(startConditions + 7,
                                                              (endConditions - startConditions - 8));
                //Debug.Log(conditions);

                var unitSymbol = (units == "imperial") ? "F" : "C";
                weatherTextObject.GetComponent<TextMeshPro>().text = "" + easyTempF.ToString() + $"°{unitSymbol}\n" + conditions;
            }
        }
    }
}