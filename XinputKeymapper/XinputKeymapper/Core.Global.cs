﻿/*
    XinputKeymapper: A program to map letters or strings using a XInput control.

    Copyright (C) 2016  Lucas Cota (BrasileiroGamer)
    lucasbrunocota@live.com
    <http://www.github.com/BrasileiroGamer/>

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

/*
 *	Core.Global.cs
 *	Author: Lucas Cota (BrasileiroGamer)
 *	Description: XinputKeymapper Global Variables.
 *  Date: 2016-07-23
 */

using SharpDX.XInput;

namespace XinputKeymapper
{
	class Global
	{
		public static Controller xinputController = null; // Current Gamepad
		public static IniParser iniKeymapper = new IniParser("XinputKeymapper.ini"); // XinputKeymapper.ini

		public static string iniFirstRun = Global.iniKeymapper.Read("FirstRun"); // FirstRun Event
		public static string iniTypeSpeed = Global.iniKeymapper.Read("TypeSpeed"); // Poll Event
		public static string iniSendEnter = Global.iniKeymapper.Read("SendEnter"); // SendEnter Event
	}
}
