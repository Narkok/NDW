using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;


public class Character: MonoBehaviour {

    public enum Type {
        Knight,
        Crusader,
        Archer,
        Cavalier,
        Sentinel,
        Wizard,
        Cannon, 
        King
    }


    public enum State {
        Walk,
        Attack,
        Wait,
        Dead
    }


    public Type type = Type.Knight;
    public State state = State.Walk;
}


public static class CharacterTypeExtention {

    public static int Health(this Character.Type character) {
        switch (character) {
            case Character.Type.King: { return 1000; }
            case Character.Type.Knight: { return 100; }
            case Character.Type.Archer: { return 100; }
            case Character.Type.Wizard: { return 100; }
            case Character.Type.Cannon: { return 100; }
            case Character.Type.Crusader: { return 100; }
            case Character.Type.Cavalier: { return 100; }
            case Character.Type.Sentinel: { return 100; }
            default: return 0;
        }
    }


    public static int Price(this Character.Type character) {
        switch (character) {
            case Character.Type.King: { return 0; }
            case Character.Type.Knight: { return 100; }
            case Character.Type.Archer: { return 100; }
            case Character.Type.Wizard: { return 100; }
            case Character.Type.Cannon: { return 100; }
            case Character.Type.Crusader: { return 100; }
            case Character.Type.Cavalier: { return 100; }
            case Character.Type.Sentinel: { return 100; }
            default: return 0;
        }
    }
}
