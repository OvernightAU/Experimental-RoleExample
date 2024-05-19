using System.Collections;
using System;
using UnityEngine;
using UnityObject = UnityEngine.Object;
using Kino;
using Hazel;
// Harmful usings are blocked, dont even try lol.
// Harmony is not recommended for several compatibility reasons, so you should make event-based things instead of using harmony

public class DynamicCode
{
    public void Execute()
    {
        UnityEngine.Debug.Log("Sussy baka");
        RoleManager.Instance.AddRole<TrolleyRole>();
    }
}