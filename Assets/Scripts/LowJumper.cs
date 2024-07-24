using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LowJumper : Jumper // INHERITANCE
{
    public override void Jump() // POLYMORPHISM
    {
        JumpWithForce(JumpForce * 0.5f);
    }
}
