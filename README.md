# UnityStateMachine (Incomplete)


Demonstration of Finite State Machine within Unity.
A finite state machine is an object with a list of possible states, an initial state, with conditions that lead to the transition between states.
A popular example is the state of a player character, where two states might be "Idle" or "Walking",
but there are many uses for a state machine outside of just movement and animation.

In this implementation, the finite state machine is represented with abstract base state and concrete derived states that are tracked within a context (the CubeScript).
By clicking a colored button, you change the Cube's current state to the corresponding concrete color state.

