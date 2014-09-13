DelayedText
===========

This is a Unity script to allow for delayed text one character at a time like you see in game dialog.

Features:
---------
Modifiable character delay
Sound on character output
Override to return entire text block with no delay

Coming Soon:
---------

Usage:
---------
Since its a IENumerator that returns a yield delay you need to call it like this:

StartCoroutine(TypeText("Text to be displayed here"));

You can also pass it a string directly.
