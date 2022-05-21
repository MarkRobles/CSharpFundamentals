using System;

namespace GradeBook
{
/// <summary>
/// This is a Delegate for my Event
/// </summary>
/// <param name="sender">Any type - Who is sending this event to the rest of the world</param>
/// <param name="args">pass whatever information you want</param>
public delegate  void GradeAddedDelegate(object sender,EventArgs args);

}