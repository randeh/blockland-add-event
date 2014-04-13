function BuildMacroSO::addEvent(%this, %event)
{
	if(getField(%this.event[%this.numEvents - 1], 1) $= "ShiftBrick" && getField(%event, 1) $= "ShiftBrick")
	{
		%x = getField(%this.event[%this.numEvents - 1], 2) + getField(%event, 2);
		%y = getField(%this.event[%this.numEvents - 1], 3) + getField(%event, 3);
		%z = getField(%this.event[%this.numEvents - 1], 4) + getField(%event, 4);
		%this.event[%this.numEvents - 1] = "Server\tShiftBrick\t" @ %x TAB %y TAB %z;
	}
	else
	{
		%this.event[%this.numEvents] = %event;
		%this.numEvents++;
	}
}