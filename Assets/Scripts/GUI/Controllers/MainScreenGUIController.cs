using UnityEngine;
using System.Collections;

public class MainScreenGUIController : GuiControllerBase {

    private enum ID : int {BACKGROUND = 0, TITLE = 1};

    public override void initialize()
    {

        GuiControl control = new Background(Color.white);
        control.setId(1);
        control.setVisible();
        add(control.getId(), control);

        control = new Icon("final fantasy", 0.5f, 0.5f, 1f, 1f);
        control.setId(2);
        control.setVisible();
        add(control.getId(), control);


    }
}
