using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;


public class Character : MonoBehaviour {

    public enum Type {
        Knight,
        Archer,
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