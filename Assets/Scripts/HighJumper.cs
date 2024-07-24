using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighJumper : Jumper // INHERITANCE
{
    public override void Jump() // POLYMORPHISM
    {
        JumpWithForce(JumpForce * 2f);
    }
}
