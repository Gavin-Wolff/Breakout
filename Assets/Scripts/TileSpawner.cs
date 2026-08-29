using UnityEngine;

public class TileSpawner : MonoBehaviour
{
    public GameObject tilePrefab;
    public int columns = 6;
    public int rows = 3;
    public float tileWidth = 1f;
    public float tileHeight = 0.5f;
    public float horizontalGap = 0.1f;
    public float verticalGap = 0.1f;
    public float startX = -2.5f;
    public float startY = 4f;

    private void Start()
    {
        SpawnTiles();
    }

    private void SpawnTiles()
    {
        if (tilePrefab == null)
        {
            Debug.LogError("Tile prefab is not assigned!");
            return;
        }

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < columns; col++)
            {
                float x = startX + (col * GetHorizontalSpacing());
                float y = startY - (row * GetVerticalSpacing());

                Vector3 spawnPosition = new Vector3(x, y, 0);
                Instantiate(tilePrefab, spawnPosition, Quaternion.identity, transform);
            }
        }
    }

    public float GetHorizontalSpacing()
    {
        return tileWidth + horizontalGap;
    }

    public float GetVerticalSpacing()
    {
        return tileHeight + verticalGap;
    }


    public void ResetTiles()
{
    foreach (Transform child in transform)
    {
        Destroy(child.gameObject);
    }

    SpawnTiles();
}
}
