using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Tile : MonoBehaviour
{
    public TitleState state { get; private set; }
    public TileCell cell { get; private set; }
    public int number { get; private set; }
    private Image background;
    private TextMeshProUGUI text;

    private void Awake()
    {
        background = GetComponent<Image>();
        text = GetComponentInChildren<TextMeshProUGUI>();
    }

    public void SetState(TitleState state, int numbers)
    {
        this.state = state;
        this.number = number;
        
        //Обновление цвета
        background.color = state.backgroundColor;
        text.color = state.textColor;
        text.text = number.ToString();
    }

    public void Spawn(TileCell cell)
    {
        if (this.cell != null)
        {
            this.cell.tile = null;
        }
        this.cell = cell;
        this.cell.tile = this;

        transform.position = cell.transform.transform.position;
    }

    public void MoveTo(TileCell cell)
    {
        if (this.cell != null)
        {
            this.cell.tile = null;
        }
        this.cell = cell;
        this.cell.tile = this;

        transform.position = cell.transform.transform.position;
    }
}
