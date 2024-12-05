using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Text textField;
    private static GameManager _instance;
    public static GameManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<GameManager>();
                if (_instance == null)
                {
                    GameObject obj = new GameObject("GameManager");
                    _instance = obj.AddComponent<GameManager>();
                }
            }
            return _instance;
        }
    }

    // List of GroundTile objects
    private List<GroundTile> groundTiles = new List<GroundTile>();

    // Method to add a GroundTile to the list
    public void AddGroundTile(GroundTile groundTile)
    {
        if (!groundTiles.Contains(groundTile))
        {
            groundTiles.Add(groundTile);
            textField.text = groundTiles.Count.ToString();
        }
    }

    // Method to remove a GroundTile from the list
    public void RemoveGroundTile(GroundTile groundTile)
    {
        if (groundTiles.Contains(groundTile))
        {
            groundTiles.Remove(groundTile);
             textField.text = groundTiles.Count.ToString();
        }
    }
}
