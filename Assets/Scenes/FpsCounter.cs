using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class FpsCounter : MonoBehaviour
{
    Text text;
    int preTime = 0;
    int preFrame = 0;

    private void Start()
    {
        text = GetComponent<Text>();
    }

    void Update()
    {
        int currentTime = (int)Time.time;

        if (preTime < currentTime)
        {
            int currentFrame = Time.frameCount;
            int fps = currentFrame - preFrame;
            text.text = $"{fps} fps\r\n{(1000f / fps).ToString("N1")} ms";

            preTime= currentTime;
            preFrame = currentFrame;
        }
    }
}
