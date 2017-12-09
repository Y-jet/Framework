using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PageState {

    public abstract void Start();

    public abstract void Update();

    public abstract void End();

    public abstract void Receive();

    public abstract void Send();


}
