using System;
using UnityEngine;
using UnityEngine.UI;

public class GoldProducer : MonoBehaviour
{
    private PlayerScript player;
    private int goldProducerCost = 100;
    private float elapsedTime = 3;
    private float resetElapsedTime;
    private int goldToAdd = 1;
    private int goldProduced;
    private Canvas _canvas;
    private string textbox;

    void Start()
    {
        _canvas = FindObjectOfType<Canvas>();
        var goldProducerText = new GameObject("GoldProducerText");
        goldProducerText.transform.SetParent(_canvas.transform);
        var text = goldProducerText.AddComponent<Text>();
        var textbox = text;
        player = FindObjectOfType<PlayerScript>();
        resetElapsedTime = elapsedTime;
    }

    void Update()
    {
        this.textbox = $"Goldpress: {goldProduced} gold | {Math.Round(elapsedTime)} sec";
        elapsedTime -= Time.deltaTime;
        if (elapsedTime <= 0)
        {
            player.GoldAmount += goldToAdd;
            goldProduced++;
            elapsedTime = resetElapsedTime;
        }
    }

    public int GoldProducerCost => goldProducerCost;
}
