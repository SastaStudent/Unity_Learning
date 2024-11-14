# There are two method of Calling Api in Unity
## 1. Call API using Coroutine

### 1. For Getting  String response/Json
```csharp
private IEnumerator GetReq(string url)
{
    using (UnityWebRequest request = UnityWebRequest.Get(url))
    {
        // Send the request and wait for the response
        yield return request.SendWebRequest();

        // Check for errors
        if (request.result == UnityWebRequest.Result.Success)
        {
            // If the request was successful, parse the response
            //(parsing our request to string)
            string jsonResponse = request.downloadHandler.text;
            // Debug.Log("Response : " + jsonResponse);

            // Deserialize the JSON response to a ResponseClass object
            // (Converting data from string to Json) => which leads to an object
            ResponseClass user = JsonUtility.FromJson<ResponseClass>(jsonResponse);
            // here we can store this user data in Database for future use.

            //checking data after fetching
            Debug.Log("User Login: "+ user.login);
            Debug.Log("User Name: "+ user.name);
            Debug.Log("User Bio: "+ user.bio);
            Name.text = user.name;
            followers.text = user.followers.ToString();
            followings.text = user.following.ToString();
            txt.text = user.bio;
            // image.sprite = user.avatar_url;
            StartCoroutine(GetAvatar(user.avatar_url));
                 
        }
        else
        {
            // Handle errors (e.g., network issues or bad status code)
            input.text="";
            Debug.Log("Error");
            Debug.LogError($"Request failed: {request.error}");
                 
        }
    }
}
```
### 2. For getting Images
```csharp
private IEnumerator GetAvatar(string url)
{
    // Now, make the request to download the texture (image)
    using (UnityWebRequest textureRequest = UnityWebRequestTexture.GetTexture(url))
    {
        // Wait for the request to finish
        yield return textureRequest.SendWebRequest();

        if (textureRequest.result == UnityWebRequest.Result.Success)
        {
            // Get the downloaded texture from the request
            Texture2D texture = ((DownloadHandlerTexture)textureRequest.downloadHandler).texture;

            // Create a sprite from the downloaded texture
            Sprite sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(0.5f, 0.5f));

            // Assign the sprite to the Image component
            image.sprite = sprite;
        }
        else
        {
            // If there's an error in the texture request, print the error message
            Debug.LogError("Failed to load avatar image: " + textureRequest.error);
        }
    }
}
```
 
