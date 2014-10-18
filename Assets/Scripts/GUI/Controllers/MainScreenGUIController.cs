using UnityEngine;
using System.Collections;

public class MainScreenGUIController : GuiControllerBase {


    public override void initialize()
    {
        this.controls.Add(new Background(Color.white));
        float titleWidth = 0.550f;
        float titleHeight = 0.300f;
        this.controls.Add(new Icon("final fantasy", 0.5f - (titleWidth / 2), 0.5f - (titleHeight / 2), titleWidth, titleHeight));
    }
}
