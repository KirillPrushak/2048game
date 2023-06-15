using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileBoard : MonoBehaviour
{
    public Tile tilePrefab;
    public TitleState[] tileStates;
    public TileGrid grid;
    private List<Tile> tiles;

    private void Awake()
    {
        grid = GetComponentInChildren<TileGrid>();
        //Создаём список с количеством плиток
        tiles = new List<Tile>(16);
    }

    private void Start()
    {
        CreateTile();
        CreateTile();
    }
    
    //Создаем функцию для создания новой плитки
    private void CreateTile()
    {
        Tile tile = Instantiate(tilePrefab, grid.transform);
        //Состояние плитки нулевое, и мы обращаемся к первому в нашем массиве, число которе будет равным 2.
        tile.SetState(tileStates[0], 2);
        //Создание пустой плитки в первый раз
        tile.Spawn(grid.GetRandomEmptyCell());
        tiles.Add(tile);
    }
}
