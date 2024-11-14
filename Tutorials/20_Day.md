# Saving & Fetching at PersistentDataPath

### Required Things
1. using System.IO;
2. using System.Runtime.Serialization.Formatters.Binary;
3. Make a Static Class 

```csharp
public static class SaveSystem
{
    public static void SavePlayer(Player player)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.bin";
        //here persistentDataPath gives a suitable path for all platforms
        //after that we can create own path where all data are stored
        FileStream stream = new FileStream(path,FileMode.Create);//read this things

        PlayerData data = new PlayerData(player);//Player data is class holding all values

        formatter.Serialize(stream,data);
        stream.close();//neccessary
    }

    public static PlayerData LoadPlayer()
    {
        string path = Application.persistentDataPath+"/plyaer.bin";
        if(File.Exists(path))
        {
            // load player
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path,FileMode.Open);

            // give all saved data to the player.
            //PlayerData = SaveData on file
            //return saved data
        }
        else{
            // not saved file
            //return null or message for taking futher action
        }
    }
}
```
5. After that you have to make Button or Shortcut cmd to Load and Save the Game according to yourself;