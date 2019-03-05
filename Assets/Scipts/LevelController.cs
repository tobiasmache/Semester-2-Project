using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Tilemaps;

public class LevelController : MonoBehaviour {

    [SerializeField] private string newLevel;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(newLevel);
        }
    }

    public Tilemap DarkMap;
    public Tilemap DimMap;
    public Tilemap BackgroundMap;

    public Tile DarkTile;
    public Tile DimTile;

    private void Start()
    {
        DarkMap.origin = DimMap.origin=BackgroundMap.origin;
        DarkMap.size = DimMap.size=BackgroundMap.size;

        foreach (Vector3Int p in DarkMap.cellBounds.allPositionsWithin)
        {
            DarkMap.SetTile(p, DarkTile);
        }

        foreach (Vector3Int p in DimMap.cellBounds.allPositionsWithin)
        {
            DimMap.SetTile(p, DimTile);
        }
    }
}
