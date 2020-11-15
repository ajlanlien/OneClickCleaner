using System;
using System.ComponentModel.DataAnnotations;

public class Schedule
{
	public Schedule()
	{

	}

	[Required]
	public string MyTime { get; set; }
}
