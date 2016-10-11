var target = Argument("target", "Default");

var HELLO = "Hello";

Task("Default")
    .Does(() => SayHi());

void SayHi()
{
    Information(HELLO);
}

RunTarget(target);