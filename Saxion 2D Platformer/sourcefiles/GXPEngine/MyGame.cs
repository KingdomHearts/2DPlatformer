using System;
using GXPEngine;
using System.Drawing;

public class MyGame : Game
{
    Level level;
	public MyGame () : base(800, 600, false)
	{
        level = new Level();
        AddChild(level);
	}
	
	void Update () {
		//empty
	}

	static void Main() {
		new MyGame().Start();
	}
}

