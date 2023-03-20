# PIANO GAME?

I'm TAing the Music and Gameplay class, and recently I taught a class of music theory.
And now music theory can't get out of my head. I need to make it into a game. (is it a game??)
Anyway, just listen to the clip, press the piano keys, and submit to pass each level.

~~Curent issue:
The score system is broken. After a lot of Debug.Log, the issue seems to be "isAnswered" not being set to false, which I did attempt to set them to false, but they're not working. A direct result of this is that scoreChanged can't be reset, either. I really don't know how to fix this.~~ (fixed)

Aand, if music theory is like rocket science to you, the answer for the respective levels are C, Cmaj3, Cmaj, Cmaj7. I tried having player using piano keyboard as answer input, but Unity UI is so hard to use.

I'm not particularly happy with the piano keyboard sprites I made because they ignore enharmonic equivalents and just use sharp notes to represent flat notes but I'm too tired and lazy to remake them :)

I used:
1. ASCII Level Loader;
2. Properties;
3. Singleton;
4. Arrays and for loops;

