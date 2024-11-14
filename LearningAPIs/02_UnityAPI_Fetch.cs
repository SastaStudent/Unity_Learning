using UnityEngine;
using System.Collections;
using UnityEngine.Networking;
using System.Threading.Tasks;

public class Fetch : MonoBehaviour
{    

    void Start()
    {
        string url = "https://api.github.com/users/sastastudent";
        Debug.Log("Requesting: " + url);

        // Call the asynchronous method to get the data
        StartCoroutine(GetReq(url));

    }
    public IEnumerator GetReq(string url)
    {
        using (UnityWebRequest request = UnityWebRequest.Get(url))
        {
            // Send the request and wait for the response
            yield return request.SendWebRequest();

            // Check for errors
            if (request.result == UnityWebRequest.Result.Success)
            {
                // If the request was successful, parse the response
                string jsonResponse = request.downloadHandler.text;
                // Debug.Log("Response : " + jsonResponse);

                // Deserialize the JSON response to a ResponseClass object
                ResponseClass user = JsonUtility.FromJson<ResponseClass>(jsonResponse);

                // Use the response (e.g., print it to the console)
                // Debug.Log("User Data " + user);
                Debug.Log("User Login: "+ user.login);
                Debug.Log("User Name: "+ user.name);
                 
            }
            else
            {
                // Handle errors (e.g., network issues or bad status code)
                Debug.Log("Error");
                Debug.LogError($"Request failed: {request.error}");
            }
        }
    }

    // public ResponseClass GetReq(string url)
    // {
    //     try
    //     {
    //         HttpWebRequest req =(HttpWebRequest) WebRequest.Create(url);
    //         HttpWebResponse res = (HttpWebResponse) req.GetResponse();
    //         StreamReader reader = new StreamReader(res.GetResponseStream());
    //         string json = reader.ReadToEnd();
    //         return JsonUtility.FromJson<ResponseClass>(json);
    //     }
    //     catch (WebException ex)
    //     {
    //         Debug.Log("Exception Error");
    //         throw ex;
    //     }
    // }

     
}

 
