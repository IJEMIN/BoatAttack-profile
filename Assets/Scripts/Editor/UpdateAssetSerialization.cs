using UnityEngine;

public class UpdateAssetSerialization
{
    [UnityEditor.MenuItem("Tools/Update Asset Serialization")]
    public static void UpdateAssetSerializationMethod()
    {
        // force all assets to be updated
        UnityEditor.AssetDatabase.ForceReserializeAssets();
    }
    
}
