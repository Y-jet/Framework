using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SceneState {

    public abstract void Start();

    public abstract void Update();

    public abstract void End();

    public abstract void Receive(string sceneName, int pageNumber, string pageState);

    public abstract void Send();

    public abstract void NewPage();

    public abstract void SelectPage();

}
